// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Serialization_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if CATEL_5

namespace Catel.Benchmarks.Runtime.Serialization
{
    using Catel.IoC;
    using Catel.Runtime.Serialization;
    using Catel.Runtime.Serialization.Binary;

    public class Serialization_Binary_Benchmark : SerializationBenchmarkBase
    {
        protected override ISerializer GetSerializer()
        {
            var typeFactory = TypeFactory.Default;
#pragma warning disable CS0618 // Type or member is obsolete
            var serializer = typeFactory.CreateInstance<BinarySerializer>();
#pragma warning restore CS0618 // Type or member is obsolete
            return serializer;
        }
    }
}

#endif
