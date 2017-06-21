// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HashHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class HashHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void HashHelper()
        {
            Catel.HashHelper.CombineHash(1, 2, 3, 4, 5, 7, 7, 8, 9, 10);
        }
        #endregion
    }
}