// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyBag_GetPropertyValue_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data.PropertyBag
{
    using BenchmarkDotNet.Attributes;
    using Catel.Data;

    public class PropertyBag_GetPropertyValue_Benchmark : BenchmarkBase
    {
        #region Fields
        private readonly PropertyBag _propertyBag;
        #endregion

        public PropertyBag_GetPropertyValue_Benchmark()
        {
            _propertyBag = new PropertyBag();
            _propertyBag["string"] = "available";
            _propertyBag["int"] = 42;
            _propertyBag["bool"] = true;
        }

        #region Methods
        [Benchmark]
        public string GetStringValue()
        {
            var value = _propertyBag.GetPropertyValue("string", "default");
            return value;
        }

        [Benchmark]
        public int GetIntValue()
        {
            var value = _propertyBag.GetPropertyValue("int", 0);
            return value;
        }

        [Benchmark]
        public bool GetBoolValue()
        {
            var value = _propertyBag.GetPropertyValue("bool", false);
            return value;
        }
        #endregion
    }
}