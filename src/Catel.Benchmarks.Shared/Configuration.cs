// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Configuration.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using System.IO;
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
            var resultsFolder = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "results");
            resultsFolder = Path.GetFullPath(resultsFolder);

            // When using the UI, we will export all tests instead of the local run only
            Benchmarker.ExportAllResultsInUi(resultsFolder);
        }
    }
}