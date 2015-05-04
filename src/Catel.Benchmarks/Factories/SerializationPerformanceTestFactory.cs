// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleModelSerializationFactory.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Factories
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Catel.Runtime.Serialization;
    using Catel.Runtime.Serialization.Binary;
    using Catel.Runtime.Serialization.Json;
    using Catel.Runtime.Serialization.Xml;
    using Data;
    using Infrastructure;
    using IoC;
    using Models;
    using NUnitBenchmarker;
    using NUnitBenchmarker.Configuration;

    public class SerializationPerformanceTestFactory
    {
        public IEnumerable<SerializationPerformanceTestConfiguration> Level1Models()
        {
            return GetTestCases("Level 1 models", ModelBaseTestHelper.CreateIniEntryObject());
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> Level2Models()
        {
            return GetTestCases("Level 2 models", ModelBaseTestHelper.CreateIniFileObject());
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> Level3Models()
        {
            return GetTestCases("Level 3 models", ModelBaseTestHelper.CreateComputerSettingsObject());
        }

        public IEnumerable<SerializationPerformanceTestConfiguration> ComplexObjectGraph()
        {
            return GetTestCases("Complex object graph", ComplexSerializationHierarchy.CreateComplexHierarchy());
        }

        // TODO: Circular references model
        // TODO: with 1 modifier
        // TODO: with 2 modifier
        // TODO: with 3 modifier

        public IEnumerable<SerializationPerformanceTestConfiguration> GetTestCases(string description, ModelBase model)
        {
            var batchSizes = new[] { 1, 5, 10, 25, 50, 100, 250 };

            var implementations = new List<Type>();
            implementations.Add(typeof(BinarySerializer));
            implementations.Add(typeof(JsonSerializer));
            implementations.Add(typeof(XmlSerializer));
            //implementations.Add(typeof(YamlSerializer));

            foreach (var implementation in implementations)
            {
                var runAction = new Action<IPerformanceTestCaseConfiguration>(c =>
                {
                    var serializationTestConfig = (SerializationPerformanceTestConfiguration)c;
                    var typeFactory = TypeFactory.Default;
                    var serializer = (IModelBaseSerializer)typeFactory.CreateInstance(c.TargetImplementationType);

                    using (var memoryStream = new MemoryStream())
                    {
                        serializer.Serialize(serializationTestConfig.TestModel, memoryStream);
                    }
                });

                for (int i = 0; i < batchSizes.Length; i++)
                {
                    yield return new SerializationPerformanceTestConfiguration(model)
                    {
                        Identifier = implementation.FullName,
                        //TestName = string.Format("{0} - {1}", implementation.FullName, batchSizes[i]),
                        TestName = description,
                        TargetImplementationType = implementation,
                        Size = 0,
                        Count = batchSizes[i],
                        //Divider = batchSizes[i],
                        //Prepare = prepare,
                        Run = runAction,
                        IsReusable = true,
                    };
                }
            }
        }
    }
}