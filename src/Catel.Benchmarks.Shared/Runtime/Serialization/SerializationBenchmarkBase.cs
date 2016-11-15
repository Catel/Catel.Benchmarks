// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationBenchmarkBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using System.IO;
    using BenchmarkDotNet.Attributes;
    using Catel.Runtime.Serialization;

    public abstract class SerializationBenchmarkBase
    {
        private readonly object _level1;
        private readonly object _level2;
        private readonly object _level3;
        private readonly object _complex;
        private readonly ISerializer _serializer;

        public SerializationBenchmarkBase()
        {
            _level1 = ModelBaseTestHelper.CreateIniEntryObject();
            _level2 = ModelBaseTestHelper.CreateIniFileObject();
            _level3 = ModelBaseTestHelper.CreateComputerSettingsObject();
            _complex = ComplexSerializationHierarchy.CreateComplexHierarchy();

            _serializer = GetSerializer();
        }

        public void Serialize(ISerializer serializer, object testModel)
        {
            using (var memoryStream = new MemoryStream())
            {
#if CATEL_4_5_4
                serializer.Serialize(testModel, memoryStream, null);
#else
                serializer.Serialize(testModel, memoryStream);
#endif
            }
        }

        protected abstract ISerializer GetSerializer();

        [Benchmark]
        public void SerializeLevel1Models()
        {
            Serialize(_serializer, _level1);
        }

        [Benchmark]
        public void SerializeLevel2Models()
        {
            Serialize(_serializer, _level2);
        }

        [Benchmark]
        public void SerializeLevel3Models()
        {
            Serialize(_serializer, _level3);
        }

        [Benchmark]
        public void SerializeComplexObjectGraph()
        {
            Serialize(_serializer, _complex);
        }
    }
}