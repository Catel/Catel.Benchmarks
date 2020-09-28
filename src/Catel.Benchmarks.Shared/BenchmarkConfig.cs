// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BenchmarkConfig.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Analysers;
    using BenchmarkDotNet.Columns;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;
    using BenchmarkDotNet.Exporters.Csv;
    using BenchmarkDotNet.Loggers;
    using BenchmarkDotNet.Validators;

    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            Options = ConfigOptions.KeepBenchmarkFiles;

            // Exporters
            //Add(MarkdownExporter.Default);
            //Add(MarkdownExporter.GitHub);
            //Add(AsciiDocExporter.Default);
            //Add(HtmlExporter.Default);
            //Add(CsvExporter.Default);
            AddExporter(CsvMeasurementsExporter.Default);
            //Add(RPlotExporter.Default);

            // Columns
            AddColumnProvider(DefaultColumnProviders.Instance);

            // Loggers
            AddLogger(ConsoleLogger.Default);

            // Analyzers
            AddAnalyser(EnvironmentAnalyser.Default);
            AddAnalyser(OutliersAnalyser.Default);

            // Diagnosers
            AddDiagnoser(MemoryDiagnoser.Default);
            //AddDiagnoser(InliningDiagnoser.Default);
            //AddDiagnoser(MemoryDiagnoser.Default);

            // Validators
            AddValidator((IValidator)BaselineValidator.FailOnError);
            AddValidator(JitOptimizationsValidator.FailOnError);
            AddValidator(ExecutionValidator.FailOnError);
            AddValidator(ReturnValueValidator.FailOnError);
        }
    }
}
