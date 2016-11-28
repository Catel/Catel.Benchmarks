// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MeasurementCsvMap.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Models.Maps
{
    using CsvHelper.Configuration;

    public class MeasurementCsvMap : CsvClassMap<Measurement>
    {
        public MeasurementCsvMap()
        {
            Map(x => x.Target).Name("Target");
            Map(x => x.Target_Namespace).Name("Target_Namespace");
            Map(x => x.Target_Type).Name("Target_Type");
            Map(x => x.Target_Method).Name("Target_Method");
            Map(x => x.Job_Id).Name("Job_Id");
            Map(x => x.Job_AnalyzeLaunchVariance).Name("Job_AnalyzeLaunchVariance");
            Map(x => x.Job_EvaluateOverhead).Name("Job_EvaluateOverhead");
            Map(x => x.Job_MaxStdErrRelative).Name("Job_MaxStdErrRelative");
            Map(x => x.Job_MinInvokeCount).Name("Job_MinInvokeCount");
            Map(x => x.Job_MinIterationTime).Name("Job_MinIterationTime");
            Map(x => x.Job_RemoveOutliers).Name("Job_RemoveOutliers");
            Map(x => x.Job_Affinity).Name("Job_Affinity");
            Map(x => x.Job_Jit).Name("Job_Jit");
            Map(x => x.Job_Platform).Name("Job_Platform");
            Map(x => x.Job_Runtime).Name("Job_Runtime");
            Map(x => x.Job_AllowVeryLargeObjects).Name("Job_AllowVeryLargeObjects");
            Map(x => x.Job_Concurrent).Name("Job_Concurrent");
            Map(x => x.Job_CpuGroups).Name("Job_CpuGroups");
            Map(x => x.Job_Force).Name("Job_Force");
            Map(x => x.Job_Server).Name("Job_Server");
            Map(x => x.Job_Clock).Name("Job_Clock");
            Map(x => x.Job_EngineFactory).Name("Job_EngineFactory");
            Map(x => x.Job_Toolchain).Name("Job_Toolchain");
            Map(x => x.Job_InvocationCount).Name("Job_InvocationCount");
            Map(x => x.Job_IterationTime).Name("Job_IterationTime");
            Map(x => x.Job_LaunchCount).Name("Job_LaunchCount");
            Map(x => x.Job_RunStrategy).Name("Job_RunStrategy");
            Map(x => x.Job_TargetCount).Name("Job_TargetCount");
            Map(x => x.Job_UnrollFactor).Name("Job_UnrollFactor");
            Map(x => x.Job_WarmupCount).Name("Job_WarmupCount");
            Map(x => x.Job_Display).Name("Job_Display");
            Map(x => x.Params).Name("Params");
            Map(x => x.Measurement_LaunchIndex).Name("Measurement_LaunchIndex");
            Map(x => x.Measurement_IterationMode).Name("Measurement_IterationMode");
            Map(x => x.Measurement_IterationIndex).Name("Measurement_IterationIndex");
            Map(x => x.Measurement_Nanoseconds).Name("Measurement_Nanoseconds");
            Map(x => x.Measurement_Operations).Name("Measurement_Operations");
            Map(x => x.Measurement_Value).Name("Measurement_Value");

            // Additional columns only available with the memory diagnoser
            // Would be nice if this was optional, but too much work for now
            Map(x => x.Gen0).Name("Gen_0").Default(0d);
            Map(x => x.Gen1).Name("Gen_1").Default(0d);
            Map(x => x.Gen2).Name("Gen_2").Default(0d);
            Map(x => x.AllocatedBytes).Name("Allocated_Bytes").Default(0d);
        }
    }
}