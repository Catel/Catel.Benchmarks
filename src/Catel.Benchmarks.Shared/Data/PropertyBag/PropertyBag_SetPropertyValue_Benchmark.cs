
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PropertyBag_GetPropertyValue_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data.PropertyBag
{
    using BenchmarkDotNet.Attributes;
    using Catel.Data;

    public class PropertyBag_SetPropertyValue_Benchmark
    {
        #region Fields
        private readonly PropertyBag _propertyBag = new PropertyBag();
        #endregion

        #region Methods
        [Benchmark]
        public void SetStringValue()
        {
            _propertyBag.SetPropertyValue("string", "available");
        }

        [Benchmark]
        public void SetIntValue()
        {
            _propertyBag.SetPropertyValue("int", 42);
        }

        [Benchmark]
        public void SetBoolValue()
        {
            _propertyBag.SetPropertyValue("string", true);
        }
        #endregion
    }
}