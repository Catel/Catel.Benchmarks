namespace Catel.Benchmarks.ModelBase
{
    using BenchmarkDotNet.Attributes;
    using Data.ModelBase.Fixtures;

    public class ValidatableModelBase_Constructor_Benchmark : BenchmarkBase
    {
        [Benchmark]
        public object Constructor()
        {
            var model = new ModelBasePerformanceTestModel();
            return model;
        }
    }
}
