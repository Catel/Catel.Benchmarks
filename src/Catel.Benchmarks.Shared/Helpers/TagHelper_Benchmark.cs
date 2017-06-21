namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class TagHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void AreTagsEqual()
        {
            TagHelper.AreTagsEqual("A", "B");
        }

        [Benchmark]
        public void ToString_()
        {
            TagHelper.ToString("A");
        }
        #endregion
    }
}