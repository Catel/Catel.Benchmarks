// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FastDateTime_vs_DateTime_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if !CATEL_4_2 && !CATEL_4_3 && !CATEL_4_4 && (!CATEL_4_5 || CATEL_4_5_4)

namespace Catel.Benchmarks.DateTime
{
    using Catel;
    using System;
    using BenchmarkDotNet.Attributes;

    public class FastDateTime_vs_DateTime_UtcNow_Benchmark
    {
        [Benchmark]
        public DateTime DateTime_UtcNow()
        {
            return DateTime.UtcNow;
        }

        [Benchmark]
        public DateTime FastDateTime_UtcNow()
        {
            return FastDateTime.UtcNow;
        }
    }
}

#endif