﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExporterBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Exporters
{
    using System.Collections.Generic;

    public abstract class ExporterBase : IExporter
    {
        public abstract void Export(string targetDirectory, List<ExportSummary> exportSummaries);
    }
}