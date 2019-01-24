﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BenchmarkBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Engines;

    // Uncomment to make all benchmarks slower (but probably more accurate)
    [SimpleJob(RunStrategy.Throughput, launchCount: 3, warmupCount: 2, targetCount: 10, invocationCount: 5000)]
    public abstract class BenchmarkBase
    {
    }
}
