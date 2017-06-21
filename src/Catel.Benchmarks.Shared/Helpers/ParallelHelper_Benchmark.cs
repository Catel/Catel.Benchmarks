// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParallelHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;

    public class ParallelHelper_Benchmark : BenchmarkBase
    {
        #region Fields
        private List<int> _ints;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _ints = new List<int>();
            for (var i = 0; i < 10000; i++)
            {
                _ints.Add(i);
            }
        }

        [Benchmark]
        public void ExecuteInParallel_ItemsPerBash_1000()
        {
            ParallelHelper.ExecuteInParallel(_ints, i => { });
        }

        [Benchmark]
        public void ExecuteInParallel_ItemsPerBash_500()
        {
            ParallelHelper.ExecuteInParallel(_ints, i => { }, 500);
        }

        [Benchmark]
        public void ExecuteInParallel_ItemsPerBash_100()
        {
            ParallelHelper.ExecuteInParallel(_ints, i => { }, 100);
        }
        #endregion
    }
}