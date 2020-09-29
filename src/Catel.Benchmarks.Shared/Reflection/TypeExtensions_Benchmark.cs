namespace Catel.Benchmarks.Reflection
{
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;
    using Catel.Data;
    using Catel.Reflection;

    public class TypeExtensions_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void IsClassType()
        {
            typeof(A).IsClassType();
        }

        [Benchmark]
        public void IsCollection()
        {
            typeof(List<A>).IsCollection();
        }

        [Benchmark]
        public void IsDictionary()
        {
            typeof(Dictionary<int, A>).IsDictionary();
        }

        [Benchmark]
        public void IsNullableType()
        {
            typeof(int?).IsNullableType();
        }

        [Benchmark]
        public void IsBasicType()
        {
            typeof(int).IsBasicType();
        }
        #endregion

        #region Nested type: A
        public class A : ModelBase
        {
        }
        #endregion

        [Benchmark]
        public void IsModelBase()
        {
            typeof(int).IsModelBase();
        }

        [Benchmark]
        public void GetCollectionElementType()
        {
            typeof(List<A>).GetCollectionElementType();
        }
    }
}
