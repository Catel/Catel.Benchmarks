// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResourceHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ResourceHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetString()
        {
            ResourceHelper.GetString("InfoTitle");
        }
        #endregion
    }
}