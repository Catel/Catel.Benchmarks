namespace Catel.Benchmarks.DateTime
{
    using Catel;
    using System;
    using BenchmarkDotNet.Attributes;

    public class FastDateTime_vs_DateTime_Benchmark : BenchmarkBase
    {
        [Benchmark]
        public DateTime DateTime_Now()
        {
            return DateTime.Now;
        }

        [Benchmark]
        public DateTime FastDateTime_Now()
        {
            return FastDateTime.Now;
        }
    }
}
