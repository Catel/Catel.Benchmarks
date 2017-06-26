// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.ModelBase
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Fixtures;

    public class ModelBase_SetValue_Benchmark : BenchmarkBase
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