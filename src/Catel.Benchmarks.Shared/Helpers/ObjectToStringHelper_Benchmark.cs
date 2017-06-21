namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class ObjectToStringHelper_Benchmark : BenchmarkBase
    {
        #region Fields
        private object _instance;
        #endregion

        #region Methods
        [Setup]
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
        #endregion
    }
}