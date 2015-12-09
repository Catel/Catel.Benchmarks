﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestConfiguration.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data.ModelBase.GetValue
{
    using Catel.Data;
    using Infrastructure;
    using Models;

    public class SetValuePerformanceTestConfiguration : CatelPerformanceTestCaseConfigurationBase
    {
        #region Constructors
        public SetValuePerformanceTestConfiguration(ModelBasePerformanceTestModel testModel)
        {
            TestModel = testModel;
        }
        #endregion

        #region Properties
        public ModelBasePerformanceTestModel TestModel { get; private set; }
        #endregion
    }
}