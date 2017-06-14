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
        [Setup]
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

        #region Nested type: NoRequirePropertyInjection
        public class NoRequirePropertyInjection
        {
            #region Constructors
            public NoRequirePropertyInjection()
            {
            }

            public NoRequirePropertyInjection(string param)
            {
            }

            public NoRequirePropertyInjection(string param, IServiceLocator serviceLocator)
            {
            }

            #endregion
        }
        #endregion

        #region Nested type: RequirePropertyInjection
        public class RequirePropertyInjection
        {
            #region Properties
            public IServiceLocator serviceLocator { get; set; }
            #endregion
        }
        #endregion
    }
}