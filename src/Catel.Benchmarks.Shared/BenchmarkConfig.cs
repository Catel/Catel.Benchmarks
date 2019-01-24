// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BenchmarkConfig.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Analysers;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;
    using BenchmarkDotNet.Exporters.Csv;
    using BenchmarkDotNet.Loggers;
    using BenchmarkDotNet.Validators;

    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            KeepBenchmarkFiles = true;

            // Exporters
            //Add(MarkdownExporter.Default);
            //Add(MarkdownExporter.GitHub);
            //Add(AsciiDocExporter.Default);
            //Add(HtmlExporter.Default);
            //Add(CsvExporter.Default);
            Add(CsvMeasurementsExporter.Default);
            //Add(RPlotExporter.Default);

            // Loggers
            Add(ConsoleLogger.Default);

            // Analyzers
            Add(EnvironmentAnalyser.Default);
            Add(OutliersAnalyser.Default);

            // Diagnosers
            Add(MemoryDiagnoser.Default);
            //Add(InliningDiagnoser.Default);
            //Add(MemoryDiagnoser.Default);

            // Validators
            Add((IValidator)BaselineValidator.FailOnError);
            Add(JitOptimizationsValidator.FailOnError);
            Add(ExecutionValidator.FailOnError);
            Add(ReturnValueValidator.FailOnError);
        }
    }
}
