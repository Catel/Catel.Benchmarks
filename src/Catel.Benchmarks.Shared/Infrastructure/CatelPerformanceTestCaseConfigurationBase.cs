// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CatelPerformanceTestCaseConfigurationBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Infrastructure
{
    using NUnitBenchmarker.Configuration;

    public abstract class CatelPerformanceTestCaseConfigurationBase : PerformanceTestCaseConfigurationBase
    {
        protected CatelPerformanceTestCaseConfigurationBase()
        {
            Identifier = IdentifierHelper.GetIdentifier();
        }

        public override string ToString()
        {
            return TestName;
        }
    }
}