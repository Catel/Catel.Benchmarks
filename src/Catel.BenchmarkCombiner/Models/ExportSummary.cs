// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExportSummary.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System.Collections.Generic;
    using Models;

    public class ExportSummary
    {
        public ExportSummary(IEnumerable<Measurement> measurements)
        {
            Measurements = new List<Measurement>(measurements);
        }

        public string Title { get; set; }

        public string Directory { get; set; }

        public List<Measurement> Measurements { get; private set; }
    }
}