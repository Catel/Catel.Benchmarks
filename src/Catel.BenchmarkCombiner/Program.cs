// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using BenchmarkDotNet.Environments;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Exporters;
    using Logging;
    using Models;
    using Models.Maps;

    class Program
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        #region Methods
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogListener
            {
                IgnoreCatelLogging = true
            };

#if DEBUG
            LogManager.AddDebugListener(true);
#endif

            LogManager.AddListener(consoleLogger);

            // Important note: set all the other benchmark projects as dependency for this project. Then you only
            // have to run this one and everything will be combined

            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var outputDirectory = Path.GetFullPath(Path.Combine(baseDirectory, ".."));
            var exportDirectory = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "results"));

            var benchmarkDuration = TimeSpan.Zero;

            Console.WriteLine("Do you want to run benchmarks now? (y/n)");
            var keyInfo = Console.ReadKey();
            if (string.Equals(keyInfo.KeyChar.ToString(), "y", StringComparison.OrdinalIgnoreCase))
            {
                var stopwatch = Stopwatch.StartNew();

                RunBenchmarks(baseDirectory, outputDirectory);

                stopwatch.Stop();

                benchmarkDuration = stopwatch.Elapsed;
            }

            CreateExportSummary(exportDirectory, benchmarkDuration);
        }

        static void RunBenchmarks(string baseDirectory, string outputDirectory)
        {
            var stopwatch = Stopwatch.StartNew();
            var benchmarkCount = 0;

            foreach (var directory in Directory.GetDirectories(outputDirectory))
            {
                if (baseDirectory.Equals(directory, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (RunBenchmarksForSpecificVersion(directory))
                {
                    benchmarkCount++;
                }
            }

            stopwatch.Stop();

            Log.Info($"Running {benchmarkCount} benchmarks took '{stopwatch.Elapsed}'");
        }

        static bool RunBenchmarksForSpecificVersion(string directory)
        {
            var exe = Path.Combine(directory, "Catel.Benchmarks.exe");
            if (!File.Exists(exe))
            {
                return false;
            }

            Log.Info($"Running benchmark at '{exe}'");

            var processStartInfo = new ProcessStartInfo(exe)
            {
                WorkingDirectory = directory,
            };

            var stopwatch = Stopwatch.StartNew();

            var process = Process.Start(processStartInfo);
            process.WaitForExit();

            stopwatch.Stop();

            var directoryInfo = new DirectoryInfo(directory);

            Log.Info($"Running benchmarks took '{stopwatch.Elapsed}' for '{directoryInfo.Name}'");

            return true;
        }

        static void CreateExportSummary(string exportDirectory, TimeSpan benchmarkDuration)
        {
            var stopwatch = Stopwatch.StartNew();

            var summaries = FindExportSummaries(exportDirectory);
            if (summaries.Count > 0)
            {
                var exportContext = new ExportContext(exportDirectory, summaries)
                {
                    BenchmarkDuration = benchmarkDuration
                };

                Log.Info("Calculating important benchmark summaries");

                var measurementGroups = exportContext.ExportSummaries.ConvertToMeasurementGroups();

                var benchmarkSummaries = CalculateBenchmarkSummaries(measurementGroups);

                exportContext.HighPriority.AddRange(benchmarkSummaries.Where(x => x is SlowerBenchmarkSummary).Cast<SlowerBenchmarkSummary>());
                exportContext.Improved.AddRange(benchmarkSummaries.Where(x => x is FasterBenchmarkSummary).Cast<FasterBenchmarkSummary>());

                var hostEnvironmentInfo = HostEnvironmentInfo.GetCurrent();
                exportContext.HostEnvironmentInfo.AddRange(hostEnvironmentInfo.ToFormattedString());

                Directory.CreateDirectory(exportDirectory);

                var exporters = new List<IExporter>();
                exporters.Add(new MarkdownExporter());

                foreach (var exporter in exporters)
                {
                    Log.Info($"Exporting using '{exporter.GetType().Name}' to '{exportDirectory}'");

                    exporter.Export(exportContext);
                }
            }

            stopwatch.Stop();

            Log.Info($"Generating {summaries.Count} export summary took '{stopwatch.Elapsed}'");
        }

        static List<ExportSummary> FindExportSummaries(string outputDirectory)
        {
            var summaries = new List<ExportSummary>();

            foreach (var directory in Directory.GetDirectories(outputDirectory, "*", SearchOption.TopDirectoryOnly))
            {
                var directoryInfo = new DirectoryInfo(directory);
                var summaryOutputDirectory = Path.Combine(directory, "results");

                var measurements = new List<Measurement>();

                if (Directory.Exists(summaryOutputDirectory))
                {
                    var factory = new CsvFactory();
                    var configuration = new CsvConfiguration
                    {
                        Delimiter = ";",
                        CultureInfo = new CultureInfo("en-US"),
                        IgnoreHeaderWhiteSpace = false
                    };

                    configuration.RegisterClassMap<MeasurementCsvMap>();

                    foreach (var measurementsCsvFile in Directory.GetFiles(summaryOutputDirectory, "*-measurements.csv", SearchOption.TopDirectoryOnly))
                    {
                        Log.Info($"Reading benchmark measurements from '{measurementsCsvFile}'");

                        using (var stream = new FileStream(measurementsCsvFile, FileMode.Open, FileAccess.Read))
                        {
                            using (var csvReader = factory.CreateReader(new StreamReader(stream), configuration))
                            {
                                while (csvReader.Read())
                                {
                                    var record = csvReader.GetRecord<Measurement>();
                                    measurements.Add(record);
                                }
                            }
                        }
                    }
                }

                var summary = new ExportSummary(measurements)
                {
                    Title = directoryInfo.Name,
                    Directory = summaryOutputDirectory
                };

                summaries.Add(summary);
            }

            return summaries;
        }

        static List<BenchmarkSummaryBase> CalculateBenchmarkSummaries(List<MeasurementGroup> measurementGroups)
        {
            var benchmarkSummaries = new List<BenchmarkSummaryBase>();

            foreach (var measurementGroup in measurementGroups.GroupBy(x => x.Container))
            {
                foreach (var measurementGroupGroup in measurementGroup)
                {
                    var count = measurementGroupGroup.Measurements.Count;
                    if (count <= 1)
                    {
                        // Cannot compare
                        continue;
                    }

                    var previousVersion = measurementGroupGroup.Measurements[count - 2];
                    var currentVersion = measurementGroupGroup.Measurements[count - 1];

                    var previousValue = previousVersion.AverageNanoSecondsPerOperation;
                    var currentValue = currentVersion.AverageNanoSecondsPerOperation;

                    BenchmarkSummaryBase benchmarkSummary = null;

                    if (currentValue.IsLarger(previousValue))
                    {
                        benchmarkSummary = new SlowerBenchmarkSummary(previousVersion.Version, currentVersion.Version, 
                            previousValue, currentValue);
                    }
                    else if (currentValue.IsSmaller(previousValue))
                    {
                        benchmarkSummary = new FasterBenchmarkSummary(previousVersion.Version, currentVersion.Version,
                            previousValue, currentValue);
                    }

                    if (benchmarkSummary != null)
                    {
                        benchmarkSummary.Key = measurementGroup.Key;
                        benchmarkSummary.Name = measurementGroup.Key;

                        benchmarkSummaries.Add(benchmarkSummary);
                    }
                }
            }

            return benchmarkSummaries;
        }
        #endregion
    }
}