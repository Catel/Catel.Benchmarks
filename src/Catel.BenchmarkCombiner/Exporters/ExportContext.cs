// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExportContext.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Exporters
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class ExportContext
    {
        public ExportContext(ExportConfig config, string exportDirectory, List<ExportSummary> exportSummaries)
        {
            Argument.IsNotNull(() => config);

            Configuration = config;
            HostEnvironmentInfo = new List<string>();
            HighPriority = new List<SlowerBenchmarkSummary>();
            //LowPriority = new List<SlowerBenchmarkSummary>();
            Improved = new List<FasterBenchmarkSummary>();

            ExportDirectory = exportDirectory;
            ExportSummaries = exportSummaries;
        }

        public ExportConfig Configuration { get; private set; }

        public List<string> HostEnvironmentInfo { get; private set; }

        public List<SlowerBenchmarkSummary> HighPriority { get; private set; }

        //public List<SlowerBenchmarkSummary> LowPriority { get; private set; }

        public List<FasterBenchmarkSummary> Improved { get; private set; }

        public string ExportDirectory { get; }

        public List<ExportSummary> ExportSummaries { get; }

        public TimeSpan BenchmarkDuration { get; set; }
    }
}