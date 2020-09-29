namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class LanguageHelper_Benchmark : BenchmarkBase
    {
        [Benchmark]
        public void GetString()
        {
            LanguageHelper.GetString("InfoTitle");
        }
    }
}
