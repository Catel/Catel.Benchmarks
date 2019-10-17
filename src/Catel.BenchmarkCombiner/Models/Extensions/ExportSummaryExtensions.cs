// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExportSummaryExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExportSummaryExtensions
    {
        public static List<MeasurementGroup> ConvertToMeasurementGroups(this IEnumerable<ExportSummary> exportSummaries)
        {
            var measurementGroups = new Dictionary<string, MeasurementGroup>();

            foreach (var exportSummary in exportSummaries)
            {
                foreach (var containerGroup in exportSummary.Measurements.GroupBy(x => x.Target_Type))
                {
                    foreach (var benchmarkGroup in containerGroup.GroupBy(x => x.Target_Method))
                    {
                        var key = $"{containerGroup.Key}_{benchmarkGroup.Key}";

                        if (!measurementGroups.TryGetValue(key, out var measurementGroup))
                        {
                            measurementGroup = new MeasurementGroup
                            {
                                Container = containerGroup.Key,
                                Benchmark = benchmarkGroup.Key
                            };

                            measurementGroups[key] = measurementGroup;
                        }

                        foreach (var measurement in benchmarkGroup)
                        {
                            var version = exportSummary.Version;

                            var versionMeasurement = (from x in measurementGroup.Measurements
                                                      where x.Version == version
                                                      select x).FirstOrDefault();
                            if (versionMeasurement == null)
                            {
                                versionMeasurement = new VersionMeasurements(exportSummary.Title, exportSummary.Version);

                                measurementGroup.Measurements.Add(versionMeasurement);
                            }

                            versionMeasurement.Measurements.Add(measurement);
                        }
                    }
                }
            }

            var finalGroups = measurementGroups.Values.OrderBy(x => $"{x.Container}_{x.Benchmark}").ToList();

            foreach (var finalGroup in finalGroups)
            {
                finalGroup.Measurements.Sort((x, y) => x.Version.CompareTo(y.Version));
            }

            return finalGroups;
        }
    }
}
