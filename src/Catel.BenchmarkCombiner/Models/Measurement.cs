// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Measurement.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System.Diagnostics;

    [DebuggerDisplay("{Target_Type}.{Target_Method} => {Measurement_Microseconds} μs")]
    public class Measurement
    {
        public string Target { get; set; }

        public string Target_Namespace { get; set; }

        public string Target_Type { get; set; }

        public string Target_Method { get; set; }

        public string Job_Id { get; set; }

        public string Job_AnalyzeLaunchVariance { get; set; }

        public string Job_EvaluateOverhead { get; set; }

        public string Job_MaxAbsoluteError { get; set; }

        public string Job_MaxRelativeError { get; set; }

        public string Job_MinInvokeCount { get; set; }

        public string Job_MinIterationTime { get; set; }

        public string Job_RemoveOutliers { get; set; }

        public string Job_Affinity { get; set; }

        public string Job_Jit { get; set; }

        public string Job_Platform { get; set; }

        public string Job_Runtime { get; set; }

        public string Job_AllowVeryLargeObjects { get; set; }

        public string Job_Concurrent { get; set; }

        public string Job_CpuGroups { get; set; }

        public string Job_Force { get; set; }

        public string Job_RetainVm { get; set; }

        public string Job_Server { get; set; }

        public string Job_Clock { get; set; }

        public string Job_EngineFactory { get; set; }

        public string Job_Toolchain { get; set; }

        public string Job_InvocationCount { get; set; }

        public string Job_IterationTime { get; set; }

        public string Job_LaunchCount { get; set; }

        public string Job_RunStrategy { get; set; }

        public string Job_TargetCount { get; set; }

        public string Job_UnrollFactor { get; set; }

        public string Job_WarmupCount { get; set; }

        public string Job_Display { get; set; }

        public string Params { get; set; }

        public int Measurement_LaunchIndex { get; set; }

        public string Measurement_IterationMode { get; set; }

        public int Measurement_IterationIndex { get; set; }

        public double Measurement_Nanoseconds { get; set; }

        public double Measurement_Microseconds
        {
            get { return Measurement_Nanoseconds.ConvertNanoSecondsToMicroSeconds(); }
        }

        public int Measurement_Operations { get; set; }

        public double Measurement_Value { get; set; }

        public double Gen0 { get; set; }

        public double Gen1 { get; set; }

        public double Gen2 { get; set; }

        public double AllocatedBytes { get; set; }
    }
}