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
        [GlobalSetup]
        public void Init()
        {
            _ints = new List<int>();
            for (var i = 0; i < 10000; i++)
            {
                _ints.Add(i);
            }
        }

        [Benchmark]
        public void ExecuteInParallel_ItemsPerBatch_1000()
        {
            ParallelHelper.ExecuteInParallel(_ints, i => { });
        }

        [Benchmark]
        public void ExecuteInParallel_ItemsPerBatch_500()
        {
            ParallelHelper.ExecuteInParallel(_ints, i => { }, 500);
        }

        [Benchmark]
        public void ExecuteInParallel_ItemsPerBatch_100()
        {
            ParallelHelper.ExecuteInParallel(_ints, i => { }, 100);
        }
        #endregion
    }
}
