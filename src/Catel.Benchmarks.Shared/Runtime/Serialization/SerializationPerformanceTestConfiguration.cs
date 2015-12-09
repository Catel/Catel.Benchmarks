// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestConfiguration.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Runtime.Serialization
{
    using System.Collections.Generic;
    using Catel.Runtime.Serialization;
    using Data;
    using Infrastructure;

    public class SerializationPerformanceTestConfiguration : CatelPerformanceTestCaseConfigurationBase
    {
        #region Constructors
        public SerializationPerformanceTestConfiguration(ISerializer serializer, ModelBase testModel)
        {
            Serializer = serializer;
            TestModel = testModel;
        }
        #endregion

        #region Properties
        public ISerializer Serializer { get; private set; }

        public ModelBase TestModel { get; private set; }
        #endregion
    }
}