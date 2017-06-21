// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceLocator_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.IoC
{
    using BenchmarkDotNet.Attributes;
    using Catel.IoC;

    public class ServiceLocator_Benchmark : BenchmarkBase
    {
        #region Fields
        private IServiceLocator _serviceLocator;
        private IServiceLocator _serviceLocator2;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
            _serviceLocator = new ServiceLocator();
            _serviceLocator2 = new ServiceLocator();

            _serviceLocator2.RegisterType<IServiceA, ServiceA>();
            _serviceLocator2.RegisterType<IServiceB, ServiceB>();
            _serviceLocator2.RegisterType<IServiceC, ServiceC>(RegistrationType.Transient);
            _serviceLocator2.RegisterType<IServiceD, ServiceD>(RegistrationType.Transient);
        }

        [Benchmark]
        public void RegisterType()
        {
            _serviceLocator.RegisterType<IServiceA, ServiceA>();
        }

        [Benchmark]
        public void ResolveType_Singleton()
        {
            _serviceLocator2.ResolveType<IServiceA>();
        }

        [Benchmark]
        public void ResolveType_Transient()
        {
            _serviceLocator2.ResolveType<IServiceC>();
        }

        [Benchmark]
        public void ResolveType_With_Singleton_Dependency()
        {
            _serviceLocator2.ResolveType<IServiceB>();
        }

        [Benchmark]
        public void ResolveType_With_Transient_Dependency()
        {
            _serviceLocator2.ResolveType<IServiceD>();
        }
        #endregion
    }
}