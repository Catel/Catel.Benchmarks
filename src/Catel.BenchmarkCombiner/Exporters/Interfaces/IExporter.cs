// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExporterBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Exporters
{
    public interface IExporter
    {
        #region Methods
        void Export(ExportContext exportContext);
        #endregion
    }
}