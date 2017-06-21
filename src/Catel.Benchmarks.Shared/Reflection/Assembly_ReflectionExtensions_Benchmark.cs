// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Assembly_ReflectionExtensions_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Reflection
{
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class Assembly_ReflectionExtensions_Benchmark : BenchmarkBase
    {
        #region Fields
        private Assembly _assembly;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
            _assembly = typeof(Assembly_ReflectionExtensions_Benchmark).Assembly;
        }

#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
        [Benchmark]
        public void GetExportedTypesEx()
        {
            _assembly.GetExportedTypesEx();
        }
#endif

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
        #endregion
    }
}