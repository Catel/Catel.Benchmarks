namespace Catel.Benchmarks.Helpers
{
    using BenchmarkDotNet.Attributes;

    public class ExpressionHelper_Benckmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void GetPropertyName()
        {
            var instance = new ClassA();
            var propertyName = ExpressionHelper.GetPropertyName(() => instance.PropertyA);
        }

        [Benchmark]
        public void GetOwner()
        {
            var instance = new ClassA();
            var owner = ExpressionHelper.GetOwner(() => instance.PropertyA);
        }

        #endregion

        #region Nested type: A
        public class ClassA
        {
            #region Properties
            public int PropertyA { get; set; }
            #endregion
        }
        #endregion
    }
}