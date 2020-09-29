namespace Catel.Benchmarks.DateTime
{
    using Catel;
    using System;
    using BenchmarkDotNet.Attributes;

    public class FastDateTime_vs_DateTime_UtcNow_Benchmark : BenchmarkBase
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
