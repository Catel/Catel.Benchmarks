namespace Catel.Benchmarks.Reflection
{
    using System;
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class PropertyInfo_ReflectionExtensions_Benchmark : BenchmarkBase
    {
        #region Fields
        private PropertyInfo _aPropertyInfo;
        private PropertyInfo _bPropertyInfo;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _aPropertyInfo = typeof(A).GetPropertyEx("AProperty");
            _bPropertyInfo = typeof(B).GetPropertyEx("AProperty");
        }

        [Benchmark]
        public void GetCustomAttributeEx()
        {
            _aPropertyInfo.GetCustomAttributeEx(typeof(APropertyAttribute), false);
        }

        [Benchmark]
        public void GetCustomAttributesEx()
        {
            _aPropertyInfo.GetCustomAttributesEx(false);
        }

        [Benchmark]
        public void GetCustomAttributesEx_AttributeType()
        {
            _aPropertyInfo.GetCustomAttributesEx(typeof(APropertyAttribute), false);
        }

        [Benchmark]
        public void GetCustomAttributeEx_Inherit()
        {
            _bPropertyInfo.GetCustomAttributeEx(typeof(APropertyAttribute), true);
        }

        [Benchmark]
        public void GetCustomAttributesEx_Inherit()
        {
            _bPropertyInfo.GetCustomAttributesEx(true);
        }

        [Benchmark]
        public void GetCustomAttributesEx_AttributeType__Inheritd()
        {
            _bPropertyInfo.GetCustomAttributesEx(typeof(APropertyAttribute), true);
        }
        #endregion

        #region Nested type: A
        public class A
        {
            #region Properties
            [AProperty]
            [BProperty]
            public virtual int AProperty { get; set; }
            #endregion
        }
        #endregion

        #region Nested type: APropertyAttribute
        public class APropertyAttribute : Attribute
        {
        }
        #endregion

        #region Nested type: B
        public class B : A
        {
            #region Properties
            public override int AProperty { get; set; }
            #endregion
        }
        #endregion

        #region Nested type: BPropertyAttribute
        public class BPropertyAttribute : Attribute
        {
        }
        #endregion
    }
}