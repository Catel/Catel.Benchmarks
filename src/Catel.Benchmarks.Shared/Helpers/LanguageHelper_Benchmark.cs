// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LanguageHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if !CATEL_4_2 && !CATEL_4_3

namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class LanguageHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetString()
        {
            LanguageHelper.GetString("InfoTitle");
        }
        #endregion
    }
}

#endif