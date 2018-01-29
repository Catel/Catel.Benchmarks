// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MeasurementGroupExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System;
    using System.Linq;

    public static class MeasurementGroupExtensions
    {
        public static VersionMeasurements Slowest(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageNanoSecondsPerOperation);
            return ordered.LastOrDefault();
        }

        public static VersionMeasurements Fastest(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageNanoSecondsPerOperation);
            return ordered.FirstOrDefault();
        }

        public static bool UsesNoGenMemory(this MeasurementGroup group)
        {
            foreach (var version in group.Measurements)
            {
                if (version.AverageGen0Per1000Operations > 0)
                {
                    return false;
                }

                if (version.AverageGen1Per1000Operations > 0)
                {
                    return false;
                }

                if (version.AverageGen2Per1000Operations > 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool UsesNoMemory(this MeasurementGroup group)
        {
            foreach (var version in group.Measurements)
            {
                if (version.AverageAllocatedBytesPer1000Operations > 0)
                {
                    return false;
                }
            }

            if (!group.UsesNoGenMemory())
            {
                return false;
            }

            return true;
        }

        public static VersionMeasurements MostGen0(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageGen0Per1000Operations);
            var value = ordered.LastOrDefault();

            if (value != null && value.AverageGen0Per1000Operations == 0)
            {
                return null;
            }

            return value;
        }

        public static VersionMeasurements LeastGen0(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageGen0Per1000Operations);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostGen1(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageGen1Per1000Operations);
            var value = ordered.LastOrDefault();

            if (value != null && value.AverageGen1Per1000Operations == 0)
            {
                return null;
            }

            return value;
        }

        public static VersionMeasurements LeastGen1(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageGen1Per1000Operations);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostGen2(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageGen2Per1000Operations);
            var value = ordered.LastOrDefault();

            if (value != null && value.AverageGen2Per1000Operations == 0)
            {
                return null;
            }

            return value;
        }

        public static VersionMeasurements LeastGen2(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageGen2Per1000Operations);
            return ordered.FirstOrDefault();
        }

        public static VersionMeasurements MostAllocatedBytes(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageAllocatedBytesPer1000Operations);
            var value = ordered.LastOrDefault();

            if (value != null && value.AverageAllocatedBytesPer1000Operations == 0)
            {
                return null;
            }

            return value;
        }

        public static VersionMeasurements LeastAllocatedBytes(this MeasurementGroup group)
        {
            var ordered = group.GetOrderedMeasurements(x => x.AverageAllocatedBytesPer1000Operations);
            return ordered.FirstOrDefault();
        }

        private static IOrderedEnumerable<VersionMeasurements> GetOrderedMeasurements(this MeasurementGroup group, Func<VersionMeasurements, double> predicate)
        {
            var ordered = group.Measurements.OrderBy(predicate).ThenByDescending(x => x.Version);
            return ordered;
        }
    }
}