// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.ModelBase.GetValue
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Fixtures;

    public class ModelBase_Constructor_Benchmark : BenchmarkBase
    {
        [Benchmark]
        public object Constructor()
        {
            var model = new ModelBasePerformanceTestModel();
            return model;
        }
    }
}