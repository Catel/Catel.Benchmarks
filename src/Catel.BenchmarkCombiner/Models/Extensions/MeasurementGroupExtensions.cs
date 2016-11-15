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
    }
}