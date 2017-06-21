namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class LanguageHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetString()
        {
            LanguageHelper.GetString("InfoTitle");
        }
        #endregion
    }
}