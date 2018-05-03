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
            var outputDirectory = Path.GetFullPath(Path.Combine(baseDirectory, "..", ".."));
            var exportDirectory = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "..", "results"));

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
            var exe = Directory.GetFiles(directory, "Catel.Benchmarks.*.exe", SearchOption.AllDirectories).FirstOrDefault();
            if (exe == null)
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
                // TODO: Consider reading from yaml in the future
                var config = new ExportConfig
                {
                    GenerateToC = false,
                    AbsolutePerformanceThreshold = 250,
                    PercentualPerformanceThreshold = 1,
                    MaxItemsInSummaryLists = 25
                };

                var exportContext = new ExportContext(config, exportDirectory, summaries)
                {
                    BenchmarkDuration = benchmarkDuration
                };

                var threshold = new ExportThreshold
                {
                    PercentualThreshold = config.PercentualPerformanceThreshold,
                    AbsoluteThreshold = config.AbsolutePerformanceThreshold
                };

                Log.Info("Calculating important benchmark summaries");

                var measurementGroups = exportContext.ExportSummaries.ConvertToMeasurementGroups();

                var benchmarkSummaries = CalculateBenchmarkSummaries(measurementGroups);

                var highPriority = (from benchmarkSummary in benchmarkSummaries.Where(x => x is SlowerBenchmarkSummary).Cast<SlowerBenchmarkSummary>()
                                    where !benchmarkSummary.PreviousVersionInNanoSeconds.AreEqual(benchmarkSummary.CurrentVersionInNanoSeconds, threshold)
                                    select benchmarkSummary).ToList();
                exportContext.HighPriority.AddRange(highPriority);

                var improved = (from benchmarkSummary in benchmarkSummaries.Where(x => x is FasterBenchmarkSummary).Cast<FasterBenchmarkSummary>()
                                where !benchmarkSummary.PreviousVersionInNanoSeconds.AreEqual(benchmarkSummary.CurrentVersionInNanoSeconds, threshold)
                                select benchmarkSummary).ToList();
                exportContext.Improved.AddRange(improved);

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
                    var configuration = new Configuration
                    {
                        Delimiter = ";",
                        CultureInfo = new CultureInfo("en-US"),
                        TrimOptions = TrimOptions.InsideQuotes
                    };

                    configuration.RegisterClassMap<MeasurementCsvMap>();

                    foreach (var measurementsCsvFile in Directory.GetFiles(summaryOutputDirectory, "*-measurements.csv", SearchOption.TopDirectoryOnly))
                    {
                        Log.Info($"Reading benchmark measurements from '{measurementsCsvFile}'");

                        using (var stream = new FileStream(measurementsCsvFile, FileMode.Open, FileAccess.Read))
                        {
                            using (var csvReader = new CsvReader(new StreamReader(stream), configuration))
                            {
                                while (csvReader.Read())
                                {
                                    var record = csvReader.GetRecord<Measurement>();
                                    if (record != null)
                                    {
                                        measurements.Add(record);
                                    }
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

                    var percentage = (previousValue / 100) * (currentValue - previousValue);
                    if (percentage < 1d && percentage > -1d)
                    {
                        continue;
                    }

                    BenchmarkSummaryBase benchmarkSummary = null;

                    if (currentValue.IsLarger(previousValue, null))
                    {
                        benchmarkSummary = new SlowerBenchmarkSummary(previousVersion.Version, currentVersion.Version,
                            previousValue, currentValue);
                    }
                    else if (currentValue.IsSmaller(previousValue, null))
                    {
                        benchmarkSummary = new FasterBenchmarkSummary(previousVersion.Version, currentVersion.Version,
                            previousValue, currentValue);
                    }

                    if (benchmarkSummary != null)
                    {
                        benchmarkSummary.Key = $"{measurementGroupGroup.Container}_{measurementGroupGroup.Benchmark}";
                        benchmarkSummary.Name = $"{measurementGroupGroup.Container}::{measurementGroupGroup.Benchmark}";

                        benchmarkSummaries.Add(benchmarkSummary);
                    }
                }
            }

            return benchmarkSummaries;
        }
        #endregion
    }
}