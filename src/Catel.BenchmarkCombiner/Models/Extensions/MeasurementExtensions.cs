// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MeasurementExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    public static class MeasurementExtensions
    {
        public static double GetAverageNanoSecondsPerOperation(this Measurement measurement)
        {
            var average = measurement.Measurement_Nanoseconds / measurement.Measurement_Operations;
            return average;
        }
    }
}