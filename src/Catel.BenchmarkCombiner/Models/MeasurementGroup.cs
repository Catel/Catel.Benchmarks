// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MeasurementGroup.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System.Collections.Generic;

    public class MeasurementGroup
    {
        public MeasurementGroup()
        {
            Measurements = new List<VersionMeasurements>();
        }

        public string Container { get; set; }

        public string Benchmark { get; set; }

        public List<VersionMeasurements> Measurements { get; private set; }
    }
}