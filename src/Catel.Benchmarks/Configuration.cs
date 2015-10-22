// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Configuration.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using NUnit.Framework;
    using NUnitBenchmarker;

    [SetUpFixture]
    public class Configuration
    {
        public Configuration()
        {
            
        }

        [TearDown]
        public void TestFixtureTearDown()
        {
            Benchmarker.ExportAllResults();
        }
    }
}