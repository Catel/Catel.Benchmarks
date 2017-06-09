namespace Catel.Benchmarks.Reflection
{
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.Reflection;

    public class AssemblyExtensions__Benchmark : BenchmarkBase
    {
        #region Fields
        private Assembly _assembly;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _assembly = typeof(AssemblyExtensions__Benchmark).Assembly;
        }

        [Benchmark]
        public void GetBuildDateTime()
        {
            _assembly.GetBuildDateTime();
        }

        [Benchmark]
        public void Title()
        {
            _assembly.Title();
        }

        [Benchmark]
        public void Version()
        {
            _assembly.Version();
        }

        [Benchmark]
        public void InformationalVersion()
        {
            _assembly.InformationalVersion();
        }

        [Benchmark]
        public void Description()
        {
            _assembly.Description();
        }

        [Benchmark]
        public void Product()
        {
            _assembly.Product();
        }

        [Benchmark]
        public void Copyright()
        {
            _assembly.Copyright();
        }

        [Benchmark]
        public void Company()
        {
            _assembly.Company();
        }

        [Benchmark]
        public void GetDirectory()
        {
            _assembly.GetDirectory();
        }
        #endregion
    }
}