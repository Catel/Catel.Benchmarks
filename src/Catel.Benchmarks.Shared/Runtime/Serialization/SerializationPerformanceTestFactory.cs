// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleModelSerializationFactory.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Catel.Runtime.Serialization;
    using Catel.Runtime.Serialization.Binary;
    using Catel.Runtime.Serialization.Json;
    using Catel.Runtime.Serialization.Xml;
    using Data;
    using IoC;
    using NUnitBenchmarker.Configuration;

    public class SerializationPerformanceTestFactory
    {
        // Note: the higher the number, the longer it takes but the more accurate the numbers will be
        private const int NumberOfRuns = 100;

        public IEnumerable<SerializationPerformanceTestConfiguration> Level1Models()
        {
            return GetTestCases("Serialization - Level 1 models", ModelBaseTestHelper.CreateIniEntryObject);
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> Level2Models()
        {
            return GetTestCases("Serialization - Level 2 models", ModelBaseTestHelper.CreateIniFileObject);
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> Level3Models()
        {
            return GetTestCases("Serialization - Level 3 models", ModelBaseTestHelper.CreateComputerSettingsObject);
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> ComplexObjectGraph()
        {
            return GetTestCases("Serialization - Complex object graph", ComplexSerializationHierarchy.CreateComplexHierarchy);
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> GetTestCases(string testName, Func<ModelBase> modelFactory)
        {
            var implementations = new List<Type>();
            implementations.Add(typeof(BinarySerializer));
            implementations.Add(typeof(JsonSerializer));
            implementations.Add(typeof(XmlSerializer));
            //implementations.Add(typeof(YamlSerializer));

            var typeFactory = TypeFactory.Default;

            foreach (var implementation in implementations)
            {
                var prepareAction = new Action<IPerformanceTestCaseConfiguration>(c =>
                {
                    var serializationTestConfig = (SerializationPerformanceTestConfiguration)c;

                    serializationTestConfig.Serializer.Warmup();
                });

                var runAction = new Action<IPerformanceTestCaseConfiguration>(c =>
                {
                    var serializationTestConfig = (SerializationPerformanceTestConfiguration)c;
                    var serializer = serializationTestConfig.Serializer;
                    var testModel = serializationTestConfig.TestModel;

                    using (var memoryStream = new MemoryStream())
                    {
                        serializer.Serialize(testModel, memoryStream);
                    }
                });

                yield return new SerializationPerformanceTestConfiguration(typeFactory.CreateInstance(implementation) as ISerializer, modelFactory())
                {
                    Identifier = implementation.FullName,
                    Version = IdentifierHelper.GetIdentifier(),
                    TestName = testName,
                    TargetImplementationType = implementation,
                    Count = NumberOfRuns,
                    Prepare = prepareAction,
                    Run = runAction,
                    IsReusable = true,
                };
            }
        }
    }
}