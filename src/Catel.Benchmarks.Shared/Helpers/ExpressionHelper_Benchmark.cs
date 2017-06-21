// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExpressionHelper_Benckmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ExpressionHelper_Benchmark : BenchmarkBase
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

        #region Nested type: ClassA
        public class ClassA
        {
            #region Properties
            public int PropertyA { get; set; }
            #endregion
        }
        #endregion
    }
}