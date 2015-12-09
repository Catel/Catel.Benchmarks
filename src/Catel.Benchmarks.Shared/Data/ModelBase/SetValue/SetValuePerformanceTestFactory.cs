// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleModelSerializationFactory.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data.ModelBase.GetValue
{
    using System;
    using System.Collections.Generic;
    using IoC;
    using Models;
    using NUnitBenchmarker.Configuration;

    public class SetValuePerformanceTestFactory
    {
        public IEnumerable<SetValuePerformanceTestConfiguration> TestCases()
        {
            return GetTestCases("ModelBase - SetValue", () => new ModelBasePerformanceTestModel());
        }

        public IEnumerable<SetValuePerformanceTestConfiguration> GetTestCases(string testName, Func<ModelBasePerformanceTestModel> modelFactory)
        {
            var typeFactory = TypeFactory.Default;

            var runAction = new Action<IPerformanceTestCaseConfiguration>(c =>
            {
                var serializationTestConfig = (SetValuePerformanceTestConfiguration)c;
                var testModel = serializationTestConfig.TestModel;

                // To get a bit reliable results, use the time x 100
                for (int i = 0; i < 100; i++)
                {
                    testModel.StringProperty = string.Format("run {0}", i);
                }
            });

            yield return new SetValuePerformanceTestConfiguration(modelFactory())
            {
                Identifier = "ModelBase.SetValue() * 100",
                Version = IdentifierHelper.GetIdentifier(),
                TestName = testName,
                TargetImplementationType = typeof(Catel.Data.ModelBase),
                Count = Settings.NumberOfRuns,
                Run = runAction,
                IsReusable = true,
            };
        }
    }
}