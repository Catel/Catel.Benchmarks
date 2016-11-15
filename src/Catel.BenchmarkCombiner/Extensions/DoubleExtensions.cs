﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    public static class DoubleExtensions
    {
        public static double ConvertNanoSecondsToMicroSeconds(this double nanoSeconds)
        {
            var microSeconds = nanoSeconds / 1000d;

            return microSeconds;
        }

        public static double ConvertNanoSecondsToMilliSeconds(this double nanoSeconds)
        {
            var microSeconds = nanoSeconds.ConvertNanoSecondsToMicroSeconds();
            var milliSeconds = microSeconds / 1000d;

            return milliSeconds;
        }
    }
}