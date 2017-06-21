namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class ResourceHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetString()
        {
            ResourceHelper.GetString("InfoTitle");
        }
        #endregion
    }
}