// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationPerformanceTests.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.ModelBase.GetValue
{
    using Data.ModelBase.GetValue;
    using NUnit.Framework;
    using NUnitBenchmarker;

    [TestFixture]
    internal class SetValuePerformanceTests
    {
        // If 0, it will not be overridden
        public const int TestRunsOverride = 0;

        [TestFixtureSetUp]
        public void TestFixture()
        {
            Benchmarker.Init();
        }

        [Test, TestCaseSource(typeof(SetValuePerformanceTestFactory), "TestCases")]
        public void GetValue(SetValuePerformanceTestConfiguration config)
        {
            config.Benchmark(config.TestName, config.ToString(), TestRunsOverride);
        }
    }
}