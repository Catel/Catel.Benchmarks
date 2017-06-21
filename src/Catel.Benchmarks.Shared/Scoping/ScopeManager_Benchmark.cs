// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScopeManager_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Scoping
{
    using BenchmarkDotNet.Attributes;
    using Catel.Scoping;

    public class ScopeManager_Benchmark : BenchmarkBase
    {
        #region Methods
        [GlobalSetup]
        public void Init()
        {
            ScopeManager<object>.GetScopeManager("stored");
        }

        [Benchmark]
        public void Get_New_ScopeManager()
        {
            ScopeManager<object>.GetScopeManager("scope");
        }

        [Benchmark]
        public void Get_Existing_ScopeManager()
        {
            ScopeManager<object>.GetScopeManager("stored");
        }
        #endregion
    }
}