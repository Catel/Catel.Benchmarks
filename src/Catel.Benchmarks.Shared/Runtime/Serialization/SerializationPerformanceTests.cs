﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using NUnit.Framework;
    using NUnitBenchmarker;

    [TestFixture]
    internal class SerializationPerformanceTests
    {
        // If 0, it will not be overridden
        public const int TestRunsOverride = 0;

        [TestFixtureSetUp]
        public void TestFixture()
        {
            Benchmarker.Init();
        }

        [Test, TestCaseSource(typeof(SerializationPerformanceTestFactory), "Level1Models")]
        public void SerializeLevel1Models(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString(), TestRunsOverride);
        }

        [Test, TestCaseSource(typeof (SerializationPerformanceTestFactory), "Level2Models")]
        public void SerializeLevel2Models(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString(), TestRunsOverride);
        }

        [Test, TestCaseSource(typeof(SerializationPerformanceTestFactory), "Level3Models")]
        public void SerializeLevel3Models(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString(), TestRunsOverride);
        }

        [Test, TestCaseSource(typeof(SerializationPerformanceTestFactory), "ComplexObjectGraph")]
        public void SerializeComplexObjectGraph(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString(), TestRunsOverride);
        }
    }
}