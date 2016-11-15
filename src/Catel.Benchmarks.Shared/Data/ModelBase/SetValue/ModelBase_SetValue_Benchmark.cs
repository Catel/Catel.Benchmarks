// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.ModelBase.SetValue
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Models;

    public class ModelBase_SetValue_Benchmark
    {
        private readonly ModelBasePerformanceTestModel _model = new ModelBasePerformanceTestModel();

        [Benchmark]
        public void SetStringValue()
        {
            _model.StringProperty = "test value";
        }

        [Benchmark]
        public void SetIntValue()
        {
            _model.IntProperty = 42;
        }

        [Benchmark]
        public void SetBoolValue()
        {
            _model.BoolProperty = true;
        }
    }
}