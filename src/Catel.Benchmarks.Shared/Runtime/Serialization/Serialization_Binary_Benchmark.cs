// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Serialization_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using BenchmarkDotNet.Attributes.Jobs;
    using BenchmarkDotNet.Engines;
    using Catel.IoC;
    using Catel.Runtime.Serialization;
    using Catel.Runtime.Serialization.Binary;
   
    public class Serialization_Binary_Benchmark : SerializationBenchmarkBase
    {
        protected override ISerializer GetSerializer()
        {
            var typeFactory = TypeFactory.Default;
            var serializer = typeFactory.CreateInstance<BinarySerializer>();
            return serializer;
        }
    }
}