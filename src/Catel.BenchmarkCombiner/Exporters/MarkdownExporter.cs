// --------------------------------------------------------------------------------------------------------------------
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
        private const string FileName = "summary.md";

        #region Methods
        public override void Export(ExportContext exportContext)
        {
            var outputFileName = Path.Combine(exportContext.ExportDirectory, FileName);

            using (var stream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write))
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    // Header
                    streamWriter.WriteLine("# Benchmarks");
                    streamWriter.WriteLine();
                    streamWriter.WriteLine($"Benchmark report generated on {DateTime.Now.ToString("dd-MMM-yyyy HH:mm")}");
                    streamWriter.WriteLine();

                    if (exportContext.BenchmarkDuration > TimeSpan.Zero)
                    {
                        streamWriter.WriteLine($"Running the benchmarks took {exportContext.BenchmarkDuration}");
                        streamWriter.WriteLine();
                    }

                    streamWriter.WriteLine("All timings are average time per operation (thus the time represents a single operation)");
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("**Legend**\n");
                    streamWriter.WriteLine("*ns = nanosecond*\n");
                    streamWriter.WriteLine("*μs = microsecond (= 1000 nanoseconds)*\n");
                    streamWriter.WriteLine("*ms = millisecond (= 1000 microseconds)*\n");
                    streamWriter.WriteLine();

                    var measurementGroups = exportContext.ExportSummaries.ConvertToMeasurementGroups();

                    // Table of contents
                    streamWriter.WriteLine("## Table of contents");

                    foreach (var measurementGroup in measurementGroups.GroupBy(x => x.Container))
                    {
                        streamWriter.WriteLine($"* [{measurementGroup.Key}](#{measurementGroup.Key})");

                        foreach (var measurementGroupGroup in measurementGroup)
                        {
                            var linkId = $"{measurementGroup.Key}_{measurementGroupGroup.Benchmark}";
                            streamWriter.WriteLine($"  * [{measurementGroupGroup.Benchmark}](#{linkId})");
                        }
                    }

                    streamWriter.WriteLine();

                    // Data
                    foreach (var measurementGroup in measurementGroups.GroupBy(x => x.Container))
                    {
                        streamWriter.WriteLine($"## <a name=\"{measurementGroup.Key}\"></a>{measurementGroup.Key}");
                        streamWriter.WriteLine();

                        foreach (var measurementGroupGroup in measurementGroup)
                        {
                            var linkId = $"{measurementGroup.Key}_{measurementGroupGroup.Benchmark}";
                            streamWriter.WriteLine($"### <a name=\"{linkId}\"></a>{measurementGroupGroup.Benchmark}");
                            streamWriter.WriteLine();

                            // Performance
                            WritePerformance(measurementGroupGroup, streamWriter);

                            // Memory
                            WriteMemory(measurementGroupGroup, streamWriter);

                            streamWriter.WriteLine();
                        }
                    }
                }
            }
        }

        private void WritePerformance(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            streamWriter.WriteLine($"#### Performance\n");

            WritePerformanceSummaryAsHtml(measurementGroup, streamWriter);
            WritePerformanceTableAsHtml(measurementGroup, streamWriter);

            streamWriter.WriteLine();
        }

        private void WritePerformanceSummaryAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            var fastest = measurementGroup.Fastest();
            var slowest = measurementGroup.Slowest();
            streamWriter.WriteLine($"Fastest: **{fastest.Version}**\n");
            streamWriter.WriteLine($"Slowest: {slowest.Version}\n");

            streamWriter.WriteLine();
        }

        private void WritePerformanceTableAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            streamWriter.WriteLine("<table>");

            // Table header
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<th> </th>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<th>{version.Version}</th>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - nanoseconds
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Average ns / operation</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageNanoSecondsPerOperation:0.000} ns</td>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - microseconds
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Average μs / operation</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMicroSeconds():0.000} μs</td>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - milliseconds
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Average ms / operation</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMilliSeconds():0.000} ms</td>");
            }

            streamWriter.WriteLine("</tr>");

            streamWriter.WriteLine("</table>");
        }

        private void WriteMemory(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            streamWriter.WriteLine($"#### Memory (per 1k operations)\n");

            WriteMemorySummaryAsHtml(measurementGroup, streamWriter);
            WriteMemoryTableAsHtml(measurementGroup, streamWriter);

            streamWriter.WriteLine();
        }

        private void WriteMemorySummaryAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            streamWriter.WriteLine("<table>");

            // Table header
            streamWriter.WriteLine("<tr>");
            streamWriter.WriteLine("<th>Name</th>");
            streamWriter.WriteLine("<th>Least</th>");
            streamWriter.WriteLine("<th>Most</th>");
            streamWriter.WriteLine("</tr>");

            // Gen 0
            var leastGen0 = measurementGroup.LeastGen0();
            var mostGen0 = measurementGroup.MostGen0();
            WriteMemorySummaryLine("Gen 0", leastGen0, mostGen0, streamWriter);

            // Gen 1
            var leastGen1 = measurementGroup.LeastGen1();
            var mostGen1 = measurementGroup.MostGen1();
            WriteMemorySummaryLine("Gen 1", leastGen1, mostGen1, streamWriter);

            // Gen 2
            var leastGen2 = measurementGroup.LeastGen2();
            var mostGen2 = measurementGroup.MostGen2();
            WriteMemorySummaryLine("Gen 2", leastGen2, mostGen2, streamWriter);

            // Allocated bytes
            var leastAllocatedBytes = measurementGroup.LeastAllocatedBytes();
            var mostAllocatedBytes = measurementGroup.MostAllocatedBytes();
            WriteMemorySummaryLine("Allocated Bytes", leastAllocatedBytes, mostAllocatedBytes, streamWriter);

            streamWriter.WriteLine("</table>");

            streamWriter.WriteLine();
        }

        private void WriteMemoryTableAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter)
        {
            streamWriter.WriteLine("<table>");

            // Table header
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<th> </th>");
            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<th>{version.Version}</th>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - Gen 0
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Gen 0</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageGen0Per1000Operations}</td>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - Gen 1
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Gen 1</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageGen1Per1000Operations}</td>");
            }

            streamWriter.WriteLine("</tr>");

            // Table content - Gen 2
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Gen 2</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageGen2Per1000Operations}</td>");
            }

            // Table content - Allocated bytes
            streamWriter.WriteLine("<tr>");
            streamWriter.Write("<td>Allocated Bytes</td>");

            foreach (var version in measurementGroup.Measurements)
            {
                streamWriter.Write($"<td align=\"right\">{version.AverageAllocatedBytesPer1000Operations}</td>");
            }

            streamWriter.WriteLine("</tr>");

            streamWriter.WriteLine("</table>");
        }

        private void WriteMemorySummaryLine(string title, VersionMeasurements least, VersionMeasurements most, StreamWriter streamWriter)
        {
            streamWriter.WriteLine("<tr>");
            streamWriter.WriteLine($"<td>{title}</td>");
            streamWriter.WriteLine($"<td>{least.Version}</td>");
            streamWriter.WriteLine($"<td>{most.Version}</td>");
            streamWriter.WriteLine("</tr>");
        }
        #endregion
    }
}