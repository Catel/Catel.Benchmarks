// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MeasurementGroupExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System.Linq;

    public static class MeasurementGroupExtensions
    {
        public static VersionMeasurements Slowest(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageNanoSecondsPerOperation);
            return ordered.LastOrDefault();
        }

        public static VersionMeasurements Fastest(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageNanoSecondsPerOperation);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostGen0(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageGen0Per1000Operations);
            return ordered.LastOrDefault();
        }

        public static VersionMeasurements LeastGen0(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageGen0Per1000Operations);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostGen1(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageGen1Per1000Operations);
            return ordered.LastOrDefault();
        }

        public static VersionMeasurements LeastGen1(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageGen1Per1000Operations);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostGen2(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageGen2Per1000Operations);
            return ordered.LastOrDefault();
        }

        public static VersionMeasurements LeastGen2(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageGen2Per1000Operations);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostAllocatedBytes(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageAllocatedBytesPer1000Operations);
            return ordered.LastOrDefault();
        }

        public static VersionMeasurements LeastAllocatedBytes(this MeasurementGroup group)
        {
            var ordered = group.Measurements.OrderBy(x => x.AverageAllocatedBytesPer1000Operations);
            return ordered.FirstOrDefault();
        }
    }
}