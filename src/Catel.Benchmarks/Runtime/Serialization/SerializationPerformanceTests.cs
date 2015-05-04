// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using Factories;
    using Infrastructure;
    using IoC;
    using NUnit.Framework;
    using NUnitBenchmarker;
    using System;

    [TestFixture]
    internal class SerializationPerformanceTests
    {
        [TestFixtureSetUp]
        public void TestFixture()
        {
            Benchmarker.Init();
        }

        [Test, TestCaseSource(typeof(SerializationPerformanceTestFactory), "Level1Models")]
        public void SerializeLevel1Models(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString());
        }

        [Test, TestCaseSource(typeof (SerializationPerformanceTestFactory), "Level2Models")]
        public void SerializeLevel2Models(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString());
        }

        [Test, TestCaseSource(typeof(SerializationPerformanceTestFactory), "Level3Models")]
        public void SerializeLevel3Models(SerializationPerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString());
        }
    }
}