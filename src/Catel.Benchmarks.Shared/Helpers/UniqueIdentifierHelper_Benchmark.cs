// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UniqueIdentifierHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class UniqueIdentifierHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetUniqueIdentifier_Generic()
        {
            UniqueIdentifierHelper.GetUniqueIdentifier<int>();
        }

        [Benchmark]
        public void GetUniqueIdentifier()
        {
            UniqueIdentifierHelper.GetUniqueIdentifier(typeof(int));
        }
        #endregion
    }
}