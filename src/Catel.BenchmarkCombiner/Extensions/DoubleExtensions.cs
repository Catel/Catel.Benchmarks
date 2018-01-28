// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoubleExtensions.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.BenchmarkCombiner
{
    using System;
    using Exporters;
    using Logging;

    public static class DoubleExtensions
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

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

        public static bool AreEqual(this double v1, double v2, ExportThreshold exportThreshold)
        {
            if (v1.IsSmaller(v2, exportThreshold))
            {
                return false;
            }

            if (v1.IsLarger(v2, exportThreshold))
            {
                return false;
            }

            return true;
        }

        public static bool IsSmaller(this double v1, double v2, ExportThreshold exportThreshold)
        {
            if (v1 >= v2)
            {
                return false;
            }

            var difference = Math.Abs(v1 - v2);
            if (MatchesThreshold(v1, difference, exportThreshold))
            {
                return false;
            }

            return true;
        }

        public static bool IsLarger(this double v1, double v2, ExportThreshold exportThreshold)
        {
            if (v1 <= v2)
            {
                return false;
            }

            var difference = Math.Abs(v1 - v2);
            if (MatchesThreshold(v1, difference, exportThreshold))
            {
                return false;
            }

            return true;
        }

        private static bool MatchesThreshold(double initialValue, double delta, ExportThreshold exportThreshold)
        {
            var absoluteThreshold = 0d;
            if (exportThreshold?.AbsoluteThreshold != null)
            {
                absoluteThreshold = exportThreshold.AbsoluteThreshold.Value;
            }

            var percentualThreshold = 0d;
            if (exportThreshold?.PercentualThreshold != null)
            {
                percentualThreshold = (initialValue / 100d) * exportThreshold.PercentualThreshold.Value;
            }

            if (delta < absoluteThreshold)
            {
                //Log.Debug($"Delta '{delta}' of initial value '{initialValue}' is within absolute threshold of '{absoluteThreshold}'");
                return true;
            }

            if (delta < percentualThreshold)
            {
                //Log.Debug($"Delta '{delta}' of initial value '{initialValue}' is within percentual threshold of '{exportThreshold.PercentualThreshold.Value} % ({percentualThreshold})'");
                return true;
            }

            return false;
        }
    }
}