// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FasterBenchmarkSummary.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner.Models
{
    public class FasterBenchmarkSummary : BenchmarkSummaryBase
    {
        public FasterBenchmarkSummary(string previousVersion, string currentVersion, 
            double previousVersionInNanoSeconds, double currentVersionInNanoSeconds)
        {
            PreviousVersion = previousVersion;
            CurrentVersion = currentVersion;

            PreviousVersionInNanoSeconds = previousVersionInNanoSeconds;
            CurrentVersionInNanoSeconds = currentVersionInNanoSeconds;

            DeltaInNanoSeconds = currentVersionInNanoSeconds - previousVersionInNanoSeconds;
            Percentage = (previousVersionInNanoSeconds / 100) * DeltaInNanoSeconds;
        }

        public string PreviousVersion { get; private set; }

        public double PreviousVersionInNanoSeconds { get; private set; }

        public string CurrentVersion { get; private set; }

        public double CurrentVersionInNanoSeconds { get; private set; }

        public double Percentage { get; private set; }

        public double DeltaInNanoSeconds { get; private set; }
    }
}