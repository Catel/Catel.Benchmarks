﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MarkdownExporter.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Exporters
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MarkdownExporter : ExporterBase
    {
        #region Methods
        public override void Export(string targetDirectory, List<ExportSummary> exportSummaries)
        {
            var outputFileName = Path.Combine(targetDirectory, "summary.md");

            using (var stream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write))
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    streamWriter.WriteLine("# Benchmarks");
                    streamWriter.WriteLine();
                    streamWriter.WriteLine($"Benchmark report generated on {DateTime.Now.ToString("dd-MMM-yyyy HH:mm")}");
                    streamWriter.WriteLine();

                    var measurementGroups = exportSummaries.ConvertToMeasurementGroups();

                    foreach (var measurementGroup in measurementGroups.GroupBy(x => x.Container))
                    {
                        streamWriter.WriteLine($"## {measurementGroup.Key}");
                        streamWriter.WriteLine();

                        foreach (var measurementGroupGroup in measurementGroup)
                        {
                            streamWriter.WriteLine($"### {measurementGroupGroup.Benchmark}");
                            streamWriter.WriteLine();

                            var fastest = measurementGroupGroup.Fastest();
                            var slowest = measurementGroupGroup.Slowest();

                            streamWriter.WriteLine($"Fastest: **{fastest.Version}**");
                            streamWriter.WriteLine();
                            streamWriter.WriteLine($"Slowest: {slowest.Version}");
                            streamWriter.WriteLine();

                            WriteTableAsHtml(measurementGroupGroup, streamWriter);

                            streamWriter.WriteLine();
                        }
                    }
                }
            }
        }

        private void WriteTableAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            streamWriter.WriteLine("<table>");

            // Table header
            streamWriter.WriteLine("<tr>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<th>{version.Version}</th>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - microseconds
            streamWriter.WriteLine("<tr>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td>{version.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMicroSeconds():F} μs</td>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - milliseconds
            streamWriter.WriteLine("<tr>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td>{version.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMilliSeconds():F} ms</td>");
            }

            streamWriter.WriteLine("</tr>");

            streamWriter.WriteLine("</table>");
        }

        private void WriteTableAsMarkdown(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            // Table header
            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"| {version.Version} ");
            }

            streamWriter.WriteLine("|");

            // Table splitter
            for (var i = 0; i < measurementGroup.Measurements.Count; i++)
            {
                streamWriter.Write("|---:");
            }

            streamWriter.WriteLine("|");

            // Table content
            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"| {version.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMicroSeconds()} μs ");
            }

            streamWriter.WriteLine("|");
        }
        #endregion
    }
}