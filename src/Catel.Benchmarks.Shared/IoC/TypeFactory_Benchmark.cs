// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TypeFactory_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Catel.Benchmarks.IoC
{
    using BenchmarkDotNet.Attributes;
    using Catel.IoC;

    public class TypeFactory_Benchmark : BenchmarkBase
    {
        #region Fields
        private ITypeFactory _typeFactory;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
            _typeFactory = ServiceLocator.Default.ResolveType<ITypeFactory>();
        }

        [Benchmark]
        public void CreateInstance()
        {
            _typeFactory.CreateInstance(typeof(NoRequirePropertyInjection));
        }

        [Benchmark]
        public void CreateInstance_PropertyInjection()
        {
            _typeFactory.CreateInstance(typeof(RequirePropertyInjection));
        }

        [Benchmark]
        public void CreateInstanceWithParameters()
        {
            _typeFactory.CreateInstanceWithParameters(typeof(NoRequirePropertyInjection), "param");
        }

        [Benchmark]
        public void CreateInstanceWithParametersAndAutoCompletion()
        {
            _typeFactory.CreateInstanceWithParametersAndAutoCompletion(typeof(NoRequirePropertyInjection), "param");
        }
        #endregion
    }
}