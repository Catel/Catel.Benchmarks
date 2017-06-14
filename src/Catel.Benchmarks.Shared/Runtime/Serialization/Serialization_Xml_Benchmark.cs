// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Serialization_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using Catel.IoC;
    using Catel.Runtime.Serialization;
    using Catel.Runtime.Serialization.Xml;

    public class Serialization_Xml_Benchmark : SerializationBenchmarkBase
    {
        protected override ISerializer GetSerializer()
        {
            var typeFactory = TypeFactory.Default;
            var serializer = typeFactory.CreateInstance<XmlSerializer>();
            return serializer;
        }
    }
}