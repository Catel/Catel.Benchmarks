// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class TagHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void AreTagsEqual()
        {
            TagHelper.AreTagsEqual("A", "B");
        }

        [Benchmark]
        public void ToString_()
        {
            TagHelper.ToString("A");
        }
        #endregion
    }
}