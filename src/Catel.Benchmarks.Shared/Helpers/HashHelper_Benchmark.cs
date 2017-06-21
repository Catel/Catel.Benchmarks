namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class HashHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void HashHelper()
        {
            Catel.HashHelper.CombineHash(1, 2, 3, 4, 5, 7, 7, 8, 9, 10);
        }
        #endregion
    }
}