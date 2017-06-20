// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MethodInfo_ReflectionExtensions_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Reflection
{
    using System;
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class MethodInfo_ReflectionExtensions_Benchmark : BenchmarkBase
    {
        #region Fields
        private MethodInfo _aMethodInfo;
        private MethodInfo _bMethodInfo;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _aMethodInfo = typeof(A).GetMethodEx("AMethod");
            _bMethodInfo = typeof(B).GetMethodEx("AMethod");
        }

        [Benchmark]
        public void GetCustomAttributeEx()
        {
            _aMethodInfo.GetCustomAttributeEx(typeof(AMethodAttribute), false);
        }

        [Benchmark]
        public void GetCustomAttributesEx()
        {
            _aMethodInfo.GetCustomAttributesEx(false);
        }

        [Benchmark]
        public void GetCustomAttributesEx_AttributeType()
        {
            _aMethodInfo.GetCustomAttributesEx(typeof(AMethodAttribute), false);
        }

        [Benchmark]
        public void GetCustomAttributeEx_Inherit()
        {
            _bMethodInfo.GetCustomAttributeEx(typeof(AMethodAttribute), true);
        }

        [Benchmark]
        public void GetCustomAttributesEx_Inherit()
        {
            _bMethodInfo.GetCustomAttributesEx(true);
        }

        [Benchmark]
        public void GetCustomAttributesEx_AttributeType__Inheritd()
        {
            _bMethodInfo.GetCustomAttributesEx(typeof(AMethodAttribute), true);
        }
        #endregion

        #region Nested type: A
        public class A
        {
            #region Methods
            [AMethod]
            [BMethod]
            public virtual void AMethod()
            {
            }
            #endregion
        }
        #endregion

        #region Nested type: AMethodAttribute
        public class AMethodAttribute : Attribute
        {
        }
        #endregion

        #region Nested type: B
        public class B : A
        {
            #region Methods
            public override void AMethod()
            {
            }
            #endregion
        }
        #endregion

        #region Nested type: BMethodAttribute
        public class BMethodAttribute : Attribute
        {
        }
        #endregion
    }
}