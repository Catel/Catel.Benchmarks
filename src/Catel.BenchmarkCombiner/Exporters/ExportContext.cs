// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExportContext.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Exporters
{
    using System;
    using System.Collections.Generic;

    public class ExportContext
    {
        public ExportContext(string exportDirectory, List<ExportSummary> exportSummaries)
        {
            HostEnvironmentInfo = new List<string>();
            ExportDirectory = exportDirectory;
            ExportSummaries = exportSummaries;
        }

        public List<string> HostEnvironmentInfo { get; private set; }

        public string ExportDirectory { get; }

        public List<ExportSummary> ExportSummaries { get; }

        public TimeSpan BenchmarkDuration { get; set; }
    }
}