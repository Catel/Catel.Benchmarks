// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestConfiguration.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Infrastructure
{
    using Data;
    using NUnitBenchmarker.Configuration;

    public class SerializationPerformanceTestConfiguration : CatelPerformanceTestCaseConfigurationBase
    {
        #region Constructors
        public SerializationPerformanceTestConfiguration(ModelBase testModel)
        {
            TestModel = testModel;
        }
        #endregion

        #region Properties
        public ModelBase TestModel { get; private set; }
        #endregion

        #region Methods

        #endregion
    }
}