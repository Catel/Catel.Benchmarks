﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.ModelBase.GetValue
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Models;

    public class ModelBase_GetValue_Benchmark
    {
        private readonly ModelBasePerformanceTestModel _model = new ModelBasePerformanceTestModel();

        [Benchmark]
        public string GetStringValue()
        {
            var value = _model.StringProperty;
            return value;
        }

        [Benchmark]
        public int GetIntValue()
        {
            var value = _model.IntProperty;
            return value;
        }

        [Benchmark]
        public bool GetBoolValue()
        {
            var value = _model.BoolProperty;
            return value;
        }
    }
}