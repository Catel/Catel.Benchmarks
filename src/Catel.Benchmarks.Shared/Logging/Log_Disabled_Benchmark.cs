// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Log_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Logging
{
    using BenchmarkDotNet.Attributes;
    using Catel.Logging;

    public class Log_Disabled_Benchmark : BenchmarkBase
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        [Setup]
        public void Setup()
        {
            LogManager.IsInfoEnabled = false;
        }

        [Benchmark]
        public void Log_Info()
        {
            Log.Info("Some message");
        }

        [Benchmark]
        public void Log_Info_Format_WithoutBoxing()
        {
            Log.Info("Some message format '{0}'", "another string");
        }

        [Benchmark]
        public void Log_Info_Format_WithBoxing()
        {
            Log.Info("Some message format '{0}'", 42);
        }
    }
}