namespace Catel.Benchmarks.Scoping
{
    using BenchmarkDotNet.Attributes;
    using Catel.Scoping;

    public class ScopeManager_Benchmark : BenchmarkBase
    {
        [Setup]
        public void Init()
        {
            ScopeManager<object>.GetScopeManager("stored");
        }

        #region Methods
        [Benchmark]
        public void Get_New_ScopeManager()
        {
            ScopeManager<object>.GetScopeManager("scope");
        }

        [Benchmark]
        public void Get_Existing_ScopeManager()
        {
            ScopeManager<object>.GetScopeManager("stored");
        }
        #endregion
    }
}