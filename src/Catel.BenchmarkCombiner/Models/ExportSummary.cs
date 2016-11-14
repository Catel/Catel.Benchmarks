// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExportSummary.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System.Collections.Generic;

    public class ExportSummary
    {
        public ExportSummary()
        {
            Measurements = new List<Measurement>();
        }

        public string Title { get; set; }

        public string Directory { get; set; }

        public List<Measurement> Measurements { get; private set; }
    }
}