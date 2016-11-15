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
    using CsvHelper;
    using CsvHelper.Configuration;
    using Exporters;
    using Logging;
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

            var summaries = new List<ExportSummary>();

            foreach (var directory in Directory.GetDirectories(outputDirectory))
            {
                if (baseDirectory.Equals(directory, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                var summary = RunBenchmarks(directory);
                if (summary != null)
                {
                    summaries.Add(summary);
                }
            }

            if (summaries.Count > 0)
            {
                Directory.CreateDirectory(exportDirectory);

                var exporters = new List<IExporter>();
                exporters.Add(new MarkdownExporter());

                foreach (var exporter in exporters)
                {
                    Log.Info($"Exporting using '{exporter.GetType().Name}' to '{exportDirectory}'");

                    exporter.Export(exportDirectory, summaries);
                }
            }
        }

        static ExportSummary RunBenchmarks(string directory)
        {
            var exe = Path.Combine(directory, "Catel.Benchmarks.exe");
            if (!File.Exists(exe))
            {
                return null;
            }

            Log.Info($"Running benchmark at '{exe}'");

            var processStartInfo = new ProcessStartInfo(exe)
            {
                WorkingDirectory = directory,
            };

            var process = Process.Start(processStartInfo);
            process.WaitForExit();

            var directoryInfo = new DirectoryInfo(directory);
            var outputDirectory = Path.Combine(directory, "BenchmarkDotNet.Artifacts", "results");

            var measurements = new List<Measurement>();

            if (Directory.Exists(outputDirectory))
            {
                var factory = new CsvFactory();
                var configuration = new CsvConfiguration
                {
                    Delimiter = ";",
                    CultureInfo = new CultureInfo("en-US")
                };

                configuration.AutoMap<MeasurementCsvMap>();

                foreach (var measurementsCsvFile in Directory.GetFiles(outputDirectory, "*-measurements.csv", SearchOption.TopDirectoryOnly))
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
                Directory = outputDirectory
            };

            return summary;
        }
#endregion
    }
}