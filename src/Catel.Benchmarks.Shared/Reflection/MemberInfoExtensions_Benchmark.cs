// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberInfoExtensions_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Reflection
{
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class MemberInfoExtensions_Benchmark : BenchmarkBase
    {
        #region Fields
        private ConstructorInfo _constructorInfo;
        private MethodInfo _methodInfo;
        private PropertyInfo _propertyInfo;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
            _constructorInfo = typeof(A).GetConstructorEx(new[] {typeof(string), typeof(int)});
            _methodInfo = typeof(A).GetMethod("AMethod", new[] {typeof(string), typeof(int)});
            _propertyInfo = typeof(A).GetPropertyEx("StaticProperty");
        }

        [Benchmark]
        public void GetSignature_Constructor()
        {
            _constructorInfo.GetSignature();
        }

        [Benchmark]
        public void GetSignature_Method()
        {
            _methodInfo.GetSignature();
        }

        [Benchmark]
        public void IsStatic_Property()
        {
            _propertyInfo.IsStatic();
        }
        #endregion

        #region Nested type: A
        private class A
        {
            #region Constructors
            public A(string a, int b)
            {
            }
            #endregion

            #region Properties
            public static int StaticProperty { get; set; }
            #endregion

            #region Methods
            public void AMethod(string a, int b)
            {
            }
            #endregion
        }
        #endregion
    }
}