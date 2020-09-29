namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ObjectToStringHelper_Benchmark : BenchmarkBase
    {
        private object _instance;

        [GlobalSetup]
        public void Init()
        {
            _instance = new object();
        }

        [Benchmark]
        public void ToString_()
        {
            ObjectToStringHelper.ToString(_instance);
        }

        [Benchmark]
        public void ToFullTypeString()
        {
            ObjectToStringHelper.ToFullTypeString(_instance);
        }

        [Benchmark]
        public void ToTypeString()
        {
            ObjectToStringHelper.ToTypeString(_instance);
        }
    }
}
