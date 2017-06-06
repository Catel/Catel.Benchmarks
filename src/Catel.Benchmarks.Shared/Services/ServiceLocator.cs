﻿namespace Catel.Benchmarks.Services
{
    using BenchmarkDotNet.Attributes;
    using IoC;

    public class ServiceLocator_Benchmark : BenchmarkBase
    {
        #region Fields
        private IServiceLocator _serviceLocator;
        private IServiceLocator _serviceLocator2;
        #endregion

        #region Methods
        [Setup]
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

    public class ServiceD : IServiceD
    {
        #region Constructors
        public ServiceD(IServiceC serviceC)
        {
        }
        #endregion
    }

    public interface IServiceD
    {
    }

    public class ServiceC : IServiceC
    {
    }

    public interface IServiceC
    {
    }

    public class ServiceB : IServiceB
    {
        #region Constructors
        public ServiceB(IServiceA serviceA)
        {
        }
        #endregion
    }

    public interface IServiceB
    {
    }

    public class ServiceA : IServiceA
    {
    }

    public interface IServiceA
    {
    }
}