// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Attribute_ReflectionExtensions_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Reflection
{
    using System;
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class Attribute_ReflectionExtensions_Benchmark : BenchmarkBase
    {
        #region Fields
        private MethodInfo _aMethodInfo;
        private Type _aType;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _aType = typeof(A);
            _aMethodInfo = _aType.GetMethodEx("AMethod");
        }
        #endregion

        #region Nested type: A
        [AType]
        public class A
        {
            #region Methods
            [AMethod]
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

        #region Nested type: ATypeAttribute
        public class ATypeAttribute : Attribute
        {
        }
        #endregion

#if !CATEL_4_3 && !CATEL_4_2
        [Benchmark]
        public void GetAttribute_Generic_From_Member()
        {
            _aMethodInfo.GetAttribute<AMethodAttribute>();
        }

        [Benchmark]
        public void GetAttribute_From_Member()
        {
            _aMethodInfo.GetAttribute(typeof(AMethodAttribute));
        }

        [Benchmark]
        public void TryGetAttribute_From_Member()
        {
            Attribute attribute;
            _aMethodInfo.TryGetAttribute(typeof(AMethodAttribute), out attribute);
        }

        [Benchmark]
        public void TryGetAttribute_Generic_From_Member()
        {
            AMethodAttribute attribute;
            _aMethodInfo.TryGetAttribute(out attribute);
        }

        [Benchmark]
        public void IsDecoratedWithAttribute_Generic_From_Member()
        {
            _aMethodInfo.IsDecoratedWithAttribute<AMethodAttribute>();
        }

        [Benchmark]
        public void IsDecoratedWithAttribute_From_Member()
        {
            _aMethodInfo.IsDecoratedWithAttribute(typeof(AMethodAttribute));
        }

        [Benchmark]
        public void GetAttribute_Generic_From_Type()
        {
            _aType.GetAttribute<ATypeAttribute>();
        }

        [Benchmark]
        public void GetAttribute_From_Type()
        {
            _aType.GetAttribute(typeof(ATypeAttribute));
        }

        [Benchmark]
        public void TryGetAttribute_From_Type()
        {
            Attribute attribute;
            _aType.TryGetAttribute(typeof(ATypeAttribute), out attribute);
        }

        [Benchmark]
        public void TryGetAttribute_Generic_From_Type()
        {
            ATypeAttribute attribute;
            _aType.TryGetAttribute(out attribute);
        }

        [Benchmark]
        public void IsDecoratedWithAttribute_Generic_From_Type()
        {
            _aType.IsDecoratedWithAttribute<ATypeAttribute>();
        }

        [Benchmark]
        public void IsDecoratedWithAttribute_From_Type()
        {
            _aType.IsDecoratedWithAttribute(typeof(ATypeAttribute));
        }
#endif
    }
}