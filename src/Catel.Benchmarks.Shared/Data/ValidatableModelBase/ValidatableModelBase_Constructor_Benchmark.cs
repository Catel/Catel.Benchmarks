// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if !CATEL_4

namespace Catel.Benchmarks.ModelBase
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Fixtures;

    public class ValidatableModelBase_Constructor_Benchmark : BenchmarkBase
    {
        [Benchmark]
        public object Constructor()
        {
            var model = new ModelBasePerformanceTestModel();
            return model;
        }
    }
}

#endif