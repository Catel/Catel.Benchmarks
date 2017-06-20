// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.ModelBase.GetValue
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Fixtures;

    public class ModelBase_EqualityComparer_Benchmark : BenchmarkBase
    {
        [Benchmark]
        public object EqualityComparer()
        {
            var model = new ModelBasePerformanceTestModel();
            return model;
        }

        [Benchmark]
        public object GetHashCode_()
        {
            var model = new ModelBasePerformanceTestModel();
            return model.GetHashCode();
        }
    }
}