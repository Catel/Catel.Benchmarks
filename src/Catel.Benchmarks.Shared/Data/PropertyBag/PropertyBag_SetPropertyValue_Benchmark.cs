namespace Catel.Benchmarks.Data.PropertyBag
{
    using BenchmarkDotNet.Attributes;
    using Catel.Data;

    public class PropertyBag_SetPropertyValue_Benchmark : BenchmarkBase
    {
        private readonly PropertyBag _propertyBag = new PropertyBag();

        [Benchmark]
        public void SetStringValue()
        {
#if CATEL_5 && !CATEL_5_12
            _propertyBag.SetPropertyValue("string", "available");
#else
            _propertyBag.SetValue<string>("string", "available");
#endif
        }

        [Benchmark]
        public void SetIntValue()
        {
#if CATEL_5 && !CATEL_5_12
            _propertyBag.SetPropertyValue("int", 42);
#else
            _propertyBag.SetValue<int>("int", 42);
#endif
        }

        [Benchmark]
        public void SetBoolValue()
        {
#if CATEL_5 && !CATEL_5_12
            _propertyBag.SetPropertyValue("bool", true);
#else
            _propertyBag.SetValue<bool>("bool", true);
#endif
        }
    }
}
