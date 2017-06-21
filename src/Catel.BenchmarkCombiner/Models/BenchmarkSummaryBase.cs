// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImportantBenchmarkResult.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    public abstract class BenchmarkSummaryBase
    {
        public BenchmarkSummaryBase()
        {
        }

        public string Key { get; set; }

        public string Name { get; set; }
    }
}