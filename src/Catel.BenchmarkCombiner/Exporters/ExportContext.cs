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
            ExportDirectory = exportDirectory;
            ExportSummaries = exportSummaries;
        }

        public string ExportDirectory { get; }

        public List<ExportSummary> ExportSummaries { get; }

        public TimeSpan BenchmarkDuration { get; set; }
    }
}