// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Log_Status_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if !CATEL_4_2 && !CATEL_4_3 && !CATEL_4_4

namespace Catel.Benchmarks.Logging
{
    using BenchmarkDotNet.Attributes;

    using Catel.Logging;

    public class Log_Status_Benchmark : BenchmarkBase
    {
        #region Constants
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();
        #endregion

        #region Methods
        [GlobalSetup]
        public void Setup()
        {
            LogManager.IsStatusEnabled = true;
        }

        [Benchmark]
        public void Log_Status_Format_1_Format_Argument()
        {
            Log.Status("Some message format '{0}'", 1);
        }

        [Benchmark]
        public void Log_Status_Format_2_Format_Arguments()
        {
            Log.Status("Some message format '{0}' '{1}'", 1, 2);
        }

        [Benchmark]
        public void Log_Status_Format_3_Format_Arguments()
        {
            Log.Status("Some message format '{0}' '{1}' '{2}'", 1, 2, 3);
        }

        [Benchmark]
        public void Log_Status_Format_4_Format_Arguments()
        {
            Log.Status("Some message format '{0}' '{1}' '{2}' '{3}'", 1, 2, 3, 4);
        }

        [Benchmark]
        public void Log_Status_Format_5_Format_Arguments()
        {
            Log.Status("Some message format '{0}' '{1}' '{2}' '{3}' '{4}'", 1, 2, 3, 4, 5);
        }

        [Benchmark]
        public void Log_Status_Format_6_Format_Arguments()
        {
            Log.Status("Some message format '{0}' '{1}' '{2}' '{3}' '{4}' '{5}'", 1, 2, 3, 4, 5, 6);
        }

        [Benchmark]
        public void Log_Status_Format_7_Format_Arguments()
        {
            Log.Status("Some message format '{0}' '{1}' '{2}' '{3}' '{4}' '{5}' '{6}'", 1, 2, 3, 4, 5, 6, 7);
        }

        #endregion
    }
}

#endif