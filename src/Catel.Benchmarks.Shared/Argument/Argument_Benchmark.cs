namespace Catel.Benchmarks.Argument
{
    using System;
    using System.ComponentModel;
    using BenchmarkDotNet.Attributes;
    using Argument = Catel.Argument;

    public class Argument_Benchmark : BenchmarkBase
    {
        #region Fields
        private A _a;
        private string[] _arrayParam;
        private B _b;
        private Guid _guidParam;
        private Guid? _guidParam2;
        private Type[] _interfaceTypes;

        private object _param;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _param = new object();
            _guidParam = Guid.NewGuid();
            _guidParam2 = Guid.NewGuid();
            _arrayParam = new[] {"string", "string2"};
            _interfaceTypes = new[] {typeof(IDisposable), typeof(INotifyPropertyChanged)};

            _b = new B();
            _a = new A();
        }

        [Benchmark]
        public void IsNotNull()
        {
            Argument.IsNotNull("paramName", _param);
        }

        [Benchmark]
        public void IsNotNullOrEmpty()
        {
            Argument.IsNotNullOrEmpty("paramName", "string");
        }

        [Benchmark]
        public void IsNotEmpty()
        {
            Argument.IsNotEmpty("paramName", _guidParam);
        }

        [Benchmark]
        public void IsNotNullOrEmpty_Guid()
        {
            Argument.IsNotNullOrEmpty("paramName", _guidParam2);
        }

        [Benchmark]
        public void IsNotNullOrWhitespace()
        {
            Argument.IsNotNullOrWhitespace("paramName", "string");
        }

        [Benchmark]
        public void IsNotNullOrEmptyArray()
        {
            Argument.IsNotNullOrEmptyArray("paramName", _arrayParam);
        }

        [Benchmark]
        public void IsNotOutOfRange()
        {
            Argument.IsNotOutOfRange("paramName", 1, 0, 5);
        }

        [Benchmark]
        public void IsMinimal()
        {
            Argument.IsMinimal("paramName", 1, 0);
        }

        [Benchmark]
        public void IsMaximum()
        {
            Argument.IsMaximum("paramName", 1, 5);
        }

        [Benchmark]
        public void InheritsFrom()
        {
            Argument.InheritsFrom("paramName", typeof(B), typeof(A));
        }

        [Benchmark]
        public void InheritsFrom_Object()
        {
            Argument.InheritsFrom("paramName", _b, typeof(A));
        }

        [Benchmark]
        public void InheritsFrom_Generic()
        {
            Argument.InheritsFrom<A>("paramName", _b);
        }

        [Benchmark]
        public void ImplementsInterface_Generic()
        {
            Argument.ImplementsInterface<IDisposable>("paramName", _b);
        }

        [Benchmark]
        public void ImplementsInterface()
        {
            Argument.ImplementsInterface("paramName", _b, typeof(IDisposable));
        }

        [Benchmark]
        public void ImplementsOneOfTheInterfaces()
        {
            Argument.ImplementsOneOfTheInterfaces("paramName", typeof(B), _interfaceTypes);
        }

        [Benchmark]
        public void ImplementsOneOfTheInterfaces_Object()
        {
            Argument.ImplementsOneOfTheInterfaces("paramName", _b, _interfaceTypes);
        }

        [Benchmark]
        public void IsOfType_Object()
        {
            Argument.IsOfType("paramName", _b, typeof(B));
        }

        [Benchmark]
        public void IsOfType()
        {
            Argument.IsOfType("paramName", typeof(B), typeof(B));
        }

        [Benchmark]
        public void IsOfOneOfTheTypes_Object()
        {
            Argument.IsOfOneOfTheTypes("paramName", _b, _interfaceTypes);
        }

        [Benchmark]
        public void IsOfOneOfTheTypes()
        {
            Argument.IsOfOneOfTheTypes("paramName", typeof(B), _interfaceTypes);
        }

        [Benchmark]
        public void IsNotOfType_Object()
        {
            Argument.IsNotOfType("paramName", _b, typeof(int));
        }

        [Benchmark]
        public void IsNotOfType()
        {
            Argument.IsNotOfType("paramName", typeof(B), typeof(int));
        }

        [Benchmark]
        public void IsNotOfOneOfTheTypes_Object()
        {
            Argument.IsNotOfOneOfTheTypes("paramName", _a, _interfaceTypes);
        }

        [Benchmark]
        public void IsNotOfOneOfTheTypes()
        {
            Argument.IsNotOfOneOfTheTypes("paramName", typeof(A), _interfaceTypes);
        }

        [Benchmark]
        public void IsNotMatch()
        {
            Argument.IsNotMatch("paramName", "1234", "[A-Z]+");
        }

        [Benchmark]
        public void IsMatch()
        {
            Argument.IsMatch("paramName", "1234", "[0-9]+");
        }
        #endregion

        #region Nested type: A
        private class A
        {
        }
        #endregion

        #region Nested type: B
        private class B : A, IDisposable
        {
            #region IDisposable Members
            public void Dispose()
            {
            }
            #endregion
        }
        #endregion
    }
}