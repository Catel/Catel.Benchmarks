namespace Catel.Benchmarks.Reflection
{
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class Assembly_ReflectionExtensions_Benchmark : BenchmarkBase
    {
        private Assembly _assembly;

        [GlobalSetup]
        public void Init()
        {
            _assembly = typeof(Assembly_ReflectionExtensions_Benchmark).Assembly;
        }

        [Benchmark]
        public void GetExportedTypesEx()
        {
            _assembly.GetExportedTypesEx();
        }

        [Benchmark]
        public void GetTypesEx()
        {
            _assembly.GetTypesEx();
        }

        [Benchmark]
        public void GetCustomAttributeEx()
        {
            _assembly.GetCustomAttributeEx(typeof(AssemblyDescriptionAttribute));
        }

        [Benchmark]
        public void GetCustomAttributesEx()
        {
            _assembly.GetCustomAttributesEx(typeof(AssemblyDescriptionAttribute));
        }
    }
}
