// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BenchmarkBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Engines;

    // Uncomment to make all benchmarks slower (but probably more accurate)
//#if CATEL_5
//    [SimpleJob(RunStrategy.Throughput, BenchmarkDotNet.Jobs.RuntimeMoniker.Net472, launchCount: 3, warmupCount: 2, targetCount: 5, invocationCount: 2500)]
//#else
//    [SimpleJob(RunStrategy.Throughput, BenchmarkDotNet.Jobs.RuntimeMoniker.NetCoreApp31, launchCount: 3, warmupCount: 2, targetCount: 5, invocationCount: 2500)]
//#endif
//    [InProcess]
    public abstract class BenchmarkBase
    {
    }
}
