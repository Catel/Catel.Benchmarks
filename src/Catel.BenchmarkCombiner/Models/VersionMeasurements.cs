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
            get { return CalculateAverage(x => x.Measurement_Nanoseconds); }
        }

        public double AverageNanoSecondsPerOperation
        {
            get { return CalculateAverage(x => x.GetAverageNanoSecondsPerOperation()); }
        }

        public double AverageGen0Per1000Operations
        {
            get { return CalculateAverage(x => x.Gen0); }
        }

        public double AverageGen1Per1000Operations
        {
            get { return CalculateAverage(x => x.Gen1); }
        }

        public double AverageGen2Per1000Operations
        {
            get { return CalculateAverage(x => x.Gen2); }
        }

        public double AverageAllocatedBytesPer1000Operations
        {
            get { return CalculateAverage(x => x.AllocatedBytes); }
        }

        public List<Measurement> Measurements { get; private set; }

        private List<Measurement> GetResultMeasurements()
        {
            var resultMeasurements = (from measurement in Measurements
                                      where measurement.Measurement_IterationMode.Equals("Workload", StringComparison.OrdinalIgnoreCase) &&
                                            measurement.Measurement_IterationStage.Equals("Result", StringComparison.OrdinalIgnoreCase)
                                      orderby measurement.Measurement_IterationIndex
                                      select measurement).ToList();

            return resultMeasurements;
        }

        private double CalculateAverage(Func<Measurement, double> predicate)
        {
            var measurements = GetResultMeasurements();
            if (measurements.Count == 0)
            {
                return 0d;
            }

            var average = measurements.Average(predicate);
            return average;
        }
    }
}
