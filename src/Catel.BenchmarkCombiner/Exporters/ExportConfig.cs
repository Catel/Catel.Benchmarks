// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Config.cs" company="Catel development team">
//   Copyright (c) 2008 - 2018 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Exporters
{
    public class ExportConfig
    {
        public ExportConfig()
        {
            GenerateToC = true;
            MaxItemsInSummaryLists = 250;
        }

        public bool GenerateToC { get; set; }

        public int MaxItemsInSummaryLists { get; set; }

        public double? PercentualPerformanceThreshold { get; set; }

        public double? AbsolutePerformanceThreshold { get; set; }

        public double? PercentualMemoryThreshold { get; set; }

        public double? AbsoluteMemoryThreshold { get; set; }
    }
}