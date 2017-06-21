// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectToStringHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ObjectToStringHelper_Benchmark : BenchmarkBase
    {
        #region Fields
        private object _instance;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
            _instance = new object();
        }

        [Benchmark]
        public void ToString_()
        {
            ObjectToStringHelper.ToString(_instance);
        }

        [Benchmark]
        public void ToFullTypeString()
        {
            ObjectToStringHelper.ToFullTypeString(_instance);
        }

        [Benchmark]
        public void ToTypeString()
        {
            ObjectToStringHelper.ToTypeString(_instance);
        }
        #endregion
    }
}