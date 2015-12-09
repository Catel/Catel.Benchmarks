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

    public class GetValuePerformanceTestFactory
    {
        public IEnumerable<GetValuePerformanceTestConfiguration> TestCases()
        {
            return GetTestCases("ModelBase - GetValue", () => new ModelBasePerformanceTestModel());
        }

        public IEnumerable<GetValuePerformanceTestConfiguration> GetTestCases(string testName, Func<ModelBasePerformanceTestModel> modelFactory)
        {
            var typeFactory = TypeFactory.Default;

            var runAction = new Action<IPerformanceTestCaseConfiguration>(c =>
            {
                var serializationTestConfig = (GetValuePerformanceTestConfiguration)c;
                var testModel = serializationTestConfig.TestModel;

                // To get a bit reliable results, use the time x 100
                for (int i = 0; i < 100; i++)
                {
                    var value = testModel.StringProperty;
                }
            });

            yield return new GetValuePerformanceTestConfiguration(modelFactory())
            {
                Identifier = "ModelBase.GetValue() * 100",
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