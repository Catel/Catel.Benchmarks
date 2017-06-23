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
        private const string DecreasedBackgroundColor = "#A8D08D";
        private const string IncreasedBackgroundColor = "#FF4949";

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
                    streamWriter.Write("If versions behave the same (e.g. result in exactly the same values), this report will show ");
                    streamWriter.Write("the highest version to represent the most recent state at best.");
                    streamWriter.WriteLine();
                    streamWriter.Write("If a higher version is at least 3% slower than the previous one, it will have a red background. ");
                    streamWriter.Write("If it is at least 3% faster, it will have a green background.");
                    streamWriter.WriteLine();

                    streamWriter.WriteLine();
                    streamWriter.WriteLine("## Host environment information");
                    streamWriter.WriteLine();

                    foreach (var hostEnvironmentInfo in exportContext.HostEnvironmentInfo)
                    {
                        streamWriter.WriteLine($"{hostEnvironmentInfo}\n");
                    }

                    streamWriter.WriteLine();

                    // Important benchmarks
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("## Important benchmarks");

                    WriteSummaries("High priority (current version slower than previous one)", exportContext.HighPriority.OrderByDescending(x => x.Percentage), 
                        x => $"v{x.CurrentVersion} is **{x.Percentage:0.00}%** (Δ: {x.DeltaInNanoSeconds:0.000} ns) slower than v{x.PreviousVersion}", streamWriter);
                    WriteSummaries("Improved (current version faster than previous one)", exportContext.Improved.OrderBy(x => x.Percentage),
                        x => $"v{x.CurrentVersion} is **{(x.Percentage * -1):0.00}%** (Δ: {x.DeltaInNanoSeconds:0.000} ns) faster than v{x.PreviousVersion}", streamWriter);

                    streamWriter.WriteLine();

                    // Table of contents
                    streamWriter.WriteLine("## Table of contents");

                    var measurementGroups = exportContext.ExportSummaries.ConvertToMeasurementGroups();

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

        private void WriteSummaries<TBenchmarkSummary>(string title, IEnumerable<TBenchmarkSummary> summaries, 
            Func<TBenchmarkSummary, string> formatter, StreamWriter streamWriter)
            where TBenchmarkSummary : BenchmarkSummaryBase
        {
            var collection = summaries.ToList();

            streamWriter.WriteLine();
            streamWriter.WriteLine($"### {title}");
            streamWriter.WriteLine();
            streamWriter.WriteLine($"{collection.Count} item(s)");
            streamWriter.WriteLine();

            if (collection.Count > 0)
            {
                for (var i = 0; i < collection.Count; i++)
                {
                    var benchmarkSummary = collection[i];

                    streamWriter.WriteLine($"{i + 1}. [{benchmarkSummary.Name}](#{benchmarkSummary.Key}) {formatter(benchmarkSummary)}\n");
                }
            }

            streamWriter.WriteLine();
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
            streamWriter.WriteLine($"Δ: {(slowest.AverageNanoSecondsPerOperation - fastest.AverageNanoSecondsPerOperation):0.000} ns\n");

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

            // Table content - percentage
            WritePerformanceTableRowAsHtml(measurementGroup, streamWriter, "%", x => x.AverageNanoSecondsPerOperation);

            // Table content - nanoseconds
            WritePerformanceTableRowAsHtml(measurementGroup, streamWriter, "ns", x => x.AverageNanoSecondsPerOperation);

            // Table content - microseconds
            WritePerformanceTableRowAsHtml(measurementGroup, streamWriter, "μs", x => x.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMicroSeconds());

            // Table content - milliseconds
            WritePerformanceTableRowAsHtml(measurementGroup, streamWriter, "ms", x => x.AverageNanoSecondsPerOperation.ConvertNanoSecondsToMilliSeconds());

            streamWriter.WriteLine("</table>");
        }

        private void WritePerformanceTableRowAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter, string unit, Func<VersionMeasurements, double> valueRetriever)
        {
            streamWriter.WriteLine("<tr>");

            streamWriter.Write("<td>");

            if (unit.EqualsIgnoreCase("%"))
            {
                streamWriter.Write("Δ %");
            }
            else
            {
                streamWriter.Write($"Average {unit} / operation");
            }

            streamWriter.Write("</td>");

            VersionMeasurements lastVersion = null;

            foreach (var version in measurementGroup.Measurements)
            {
                var background = "#FFFFFF";

                var currentValue = valueRetriever(version);
                var previousValue = 0d;
                double? deltaAbsolute = null;

                if (lastVersion != null)
                {
                    previousValue = valueRetriever(lastVersion);

                    if (currentValue.IsLarger(previousValue))
                    {
                        background = IncreasedBackgroundColor;
                    }
                    else if (currentValue.IsSmaller(previousValue))
                    {
                        background = DecreasedBackgroundColor;
                    }

                    deltaAbsolute = currentValue - previousValue;
                }

                streamWriter.Write($"<td align=\"right\" bgcolor=\"{background}\">");

                if (unit.EqualsIgnoreCase("%"))
                {
                    if (deltaAbsolute.HasValue)
                    {
                        var deltaPercentage = (100 / previousValue) * deltaAbsolute;
                        var leadingSign = (deltaAbsolute > 0) ? "+" : string.Empty;

                        streamWriter.Write($"{leadingSign}{deltaPercentage:0.0} {unit}");
                    }
                }
                else
                {
                    streamWriter.Write($"{currentValue:0.000} {unit}");

                    if (deltaAbsolute.HasValue)
                    {
                        var leadingSign = (deltaAbsolute > 0) ? "+" : string.Empty;

                        streamWriter.Write($" (Δ = {leadingSign}{deltaAbsolute:0.000} {unit})");
                    }
                }

                streamWriter.Write("</td>");

                lastVersion = version;
            }

            streamWriter.WriteLine("</tr>");
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
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "Gen 0", x => x.AverageGen0Per1000Operations);

            // Table content - Gen 1
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "Gen 1", x => x.AverageGen1Per1000Operations);

            // Table content - Gen 2
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "Gen 2", x => x.AverageGen2Per1000Operations);

            // Table content - Allocated bytes %
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "%", x => x.AverageAllocatedBytesPer1000Operations);

            // Table content - Allocated bytes
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "Allocated Bytes", x => x.AverageAllocatedBytesPer1000Operations);

            // Table content - Allocated kilo bytes
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "Allocated Kilobytes", x => x.AverageAllocatedBytesPer1000Operations.ConvertBytesToKilobytes());

            // Table content - Allocated mega bytes
            WriteMemoryTableRowAsHtml(measurementGroup, streamWriter, "Allocated Megabytes", x => x.AverageAllocatedBytesPer1000Operations.ConvertBytesToMegabytes());

            streamWriter.WriteLine("</table>");
        }

        private void WriteMemoryTableRowAsHtml(MeasurementGroup measurementGroup, StreamWriter streamWriter, string unit, Func<VersionMeasurements, double> valueRetriever)
        {
            streamWriter.WriteLine("<tr>");

            streamWriter.Write("<td>");

            if (unit.EqualsIgnoreCase("%"))
            {
                streamWriter.Write("Δ %");
            }
            else
            {
                streamWriter.Write($"{unit}");
            }

            streamWriter.Write("</td>");

            VersionMeasurements lastVersion = null;

            foreach (var version in measurementGroup.Measurements)
            {
                var background = "#FFFFFF";

                var currentValue = valueRetriever(version);
                var previousValue = 0d;
                double? deltaAbsolute = null;

                if (lastVersion != null)
                {
                    previousValue = valueRetriever(lastVersion);

                    if (currentValue.IsLarger(previousValue))
                    {
                        background = IncreasedBackgroundColor;
                    }
                    else if (currentValue.IsSmaller(previousValue))
                    {
                        background = DecreasedBackgroundColor;
                    }

                    deltaAbsolute = currentValue - previousValue;
                }

                streamWriter.Write($"<td align=\"right\" bgcolor=\"{background}\">");

                if (unit.EqualsIgnoreCase("%"))
                {
                    if (deltaAbsolute.HasValue)
                    {
                        var deltaPercentage = (100 / previousValue) * deltaAbsolute;
                        var leadingSign = (deltaAbsolute > 0) ? "+" : string.Empty;

                        streamWriter.Write($"{leadingSign}{deltaPercentage:0.0} {unit}");
                    }
                }
                else
                {
                    streamWriter.Write($"{currentValue:0.000}");

                    if (deltaAbsolute.HasValue)
                    {
                        var leadingSign = (deltaAbsolute > 0) ? "+" : string.Empty;

                        streamWriter.Write($" (Δ = {leadingSign}{deltaAbsolute:0.000})");
                    }
                }

                streamWriter.Write("</td>");

                lastVersion = version;
            }

            streamWriter.WriteLine("</tr>");
        }

        private void WriteMemorySummaryLine(string title, VersionMeasurements least, VersionMeasurements most, StreamWriter streamWriter)
        {
            var hasMost = most != null;
            var leastValue = hasMost ? least.Version : "-";
            var mostValue = hasMost ? most.Version : "-";

            streamWriter.WriteLine("<tr>");
            streamWriter.WriteLine($"<td>{title}</td>");

            streamWriter.WriteLine($"<td align=\"right\">{leastValue}</td>");
            streamWriter.WriteLine($"<td align=\"right\">{mostValue}</td>");

            streamWriter.WriteLine("</tr>");
        }
        #endregion
    }
}