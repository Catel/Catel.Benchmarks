namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class EnvironmentHelper_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void IsProcessHostedByVisualStudio()
        {
            var isProcessHostedByVisualStudio = EnvironmentHelper.IsProcessHostedByVisualStudio;
        }

        [Benchmark]
        public void IsProcessHostedBySharpDevelop()
        {
            var isProcessHostedBySharpDevelop = EnvironmentHelper.IsProcessHostedBySharpDevelop;
        }

        [Benchmark]
        public void IsProcessHostedByExpressionBlend()
        {
            var isProcessHostedByExpressionBlend = EnvironmentHelper.IsProcessHostedByExpressionBlend;
        }

        [Benchmark]
        public void IsProcessHostedByTool()
        {
            var isProcessHostedByTool = EnvironmentHelper.IsProcessHostedByTool;
        }

        [Benchmark]
        public void IsProcessCurrentlyHostedByVisualStudio()
        {
            var isProcessCurrentlyHostedByVisualStudio = EnvironmentHelper.IsProcessCurrentlyHostedByVisualStudio(true);
        }

        [Benchmark]
        public void IsProcessCurrentlyHostedBySharpDevelop()
        {
            var isProcessCurrentlyHostedBySharpDevelop = EnvironmentHelper.IsProcessCurrentlyHostedBySharpDevelop(true);
        }

        [Benchmark]
        public void IsProcessCurrentlyHostedByExpressionBlend()
        {
            var isProcessCurrentlyHostedByExpressionBlend = EnvironmentHelper.IsProcessCurrentlyHostedByExpressionBlend(true);
        }

        [Benchmark]
        public void IsProcessCurrentlyHostedByTool()
        {
            var isProcessCurrentlyHostedByTool = EnvironmentHelper.IsProcessCurrentlyHostedByTool(true);
        }
        #endregion
    }
}