// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System;

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

        public static double ConvertBytesToKilobytes(this double bytes)
        {
            var kilobytes = bytes / 1024d;

            return kilobytes;
        }

        public static double ConvertBytesToMegabytes(this double bytes)
        {
            var kilobytes = bytes.ConvertBytesToKilobytes();
            var megabytes = kilobytes / 1024d;

            return megabytes;
        }

        public static bool AreEqual(this double v1, double v2, double allowedDifference = 3d)
        {
            if (v1.IsSmaller(v2, allowedDifference))
            {
                return false;
            }

            if (v1.IsLarger(v2, allowedDifference))
            {
                return false;
            }

            return true;
        }

        public static bool IsSmaller(this double v1, double v2, double allowedDifference = 3d)
        {
            var tolerance = (v1 / 100d) * allowedDifference;

            if (v1 >= v2)
            {
                return false;
            }

            var difference = Math.Abs(v1 - v2);
            if (difference < tolerance)
            {
                // Treat as equal, allowed difference
                return false;
            }

            return true;
        }

        public static bool IsLarger(this double v1, double v2, double allowedDifference = 3d)
        {
            var tolerance = (v1 / 100d) * allowedDifference;

            if (v1 <= v2)
            {
                return false;
            }

            var difference = Math.Abs(v1 - v2);
            if (difference < tolerance)
            {
                // Treat as equal, allowed difference
                return false;
            }

            return true;
        }
    }
}