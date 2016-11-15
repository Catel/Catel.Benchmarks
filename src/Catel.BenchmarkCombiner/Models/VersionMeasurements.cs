// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VersionMeasurements.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VersionMeasurements
    {
        public VersionMeasurements()
        {
            Measurements = new List<Measurement>();
        }

        public string Version { get; set; }

        public double AverageNanoSeconds
        {
            get
            {
                var measurements = GetResultMeasurements();
                if (measurements.Count == 0)
                {
                    return 0d;
                }

                var average = measurements.Average(x => x.Measurement_Nanoseconds);
                return average;
            }
        }

        public double AverageNanoSecondsPerOperation
        {
            get
            {
                var measurements = GetResultMeasurements();
                if (measurements.Count == 0)
                {
                    return 0d;
                }

                var average = measurements.Average(x => x.GetAverageNanoSecondsPerOperation());
                return average;
            }
        }

        public Measurement Slowest
        {
            get
            {
                var measurements = GetResultMeasurements();
                return measurements.OrderBy(x => x.Measurement_Nanoseconds).LastOrDefault();
            }
        }

        public Measurement Fastest
        {
            get
            {
                var measurements = GetResultMeasurements();
                return measurements.OrderBy(x => x.Measurement_Nanoseconds).LastOrDefault();
            }
        }

        public List<Measurement> Measurements { get; private set; }

        private List<Measurement> GetResultMeasurements()
        {
            var resultMeasurements = (from measurement in Measurements
                                      where measurement.Measurement_IterationMode.Equals("Result", StringComparison.OrdinalIgnoreCase)
                                      orderby measurement.Measurement_IterationIndex
                                      select measurement).ToList();

            return resultMeasurements;
        }
    }
}