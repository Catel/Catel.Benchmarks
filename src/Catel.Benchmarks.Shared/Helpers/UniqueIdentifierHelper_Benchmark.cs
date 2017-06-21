namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class UniqueIdentifierHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetUniqueIdentifier_Generic()
        {
            UniqueIdentifierHelper.GetUniqueIdentifier<int>();
        }

        [Benchmark]
        public void GetUniqueIdentifier()
        {
            UniqueIdentifierHelper.GetUniqueIdentifier(typeof(int));
        }
        #endregion
    }
}