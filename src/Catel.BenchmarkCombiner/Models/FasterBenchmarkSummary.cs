﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FasterBenchmarkSummary.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Catel.BenchmarkCombiner.Models
{
    using Semver;

    public class FasterBenchmarkSummary : BenchmarkSummaryBase
    {
        public FasterBenchmarkSummary(SemVersion previousVersion, SemVersion currentVersion,
            double previousVersionInNanoSeconds, double currentVersionInNanoSeconds)
        {
            PreviousVersion = previousVersion;
            CurrentVersion = currentVersion;

            PreviousVersionInNanoSeconds = previousVersionInNanoSeconds;
            CurrentVersionInNanoSeconds = currentVersionInNanoSeconds;

            DeltaInNanoSeconds = currentVersionInNanoSeconds - previousVersionInNanoSeconds;

            var percentage = (currentVersionInNanoSeconds * 100d) / previousVersionInNanoSeconds;
            var deltaPercentage = percentage - 100d;
            DeltaInPercentage = deltaPercentage;
        }

        public SemVersion PreviousVersion { get; private set; }

        public double PreviousVersionInNanoSeconds { get; private set; }

        public SemVersion CurrentVersion { get; private set; }

        public double CurrentVersionInNanoSeconds { get; private set; }

        public double DeltaInPercentage { get; private set; }

        public double DeltaInNanoSeconds { get; private set; }
    }
}
