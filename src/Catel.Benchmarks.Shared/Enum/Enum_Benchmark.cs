// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Enum_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Enum
{
    using BenchmarkDotNet.Attributes;

    public class Enum_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void ToList()
        {
            Enum<EnumForBenchmarkA>.ToList();
        }

        [Benchmark]
        public void ConvertFromOtherEnumValue()
        {
            Enum<EnumForBenchmarkA>.ConvertFromOtherEnumValue(EnumForBenchmarkB.A);
        }

        [Benchmark]
        public void GetName()
        {
            Enum<EnumForBenchmarkA>.GetName(0);
        }

        [Benchmark]
        public void GetName_Long()
        {
            Enum<EnumForBenchmarkA>.GetName((long) 0);
        }

        [Benchmark]
        public void GetNames()
        {
            Enum<EnumForBenchmarkA>.GetNames();
        }

        [Benchmark]
        public void GetValues()
        {
            Enum<EnumForBenchmarkA>.GetValues();
        }

        [Benchmark]
        public void Parse()
        {
            Enum<EnumForBenchmarkA>.Parse("A");
        }

        [Benchmark]
        public void TryParse_Nullable()
        {
            EnumForBenchmarkA? value;
            Enum<EnumForBenchmarkA>.TryParse("A", out value);
        }

        [Benchmark]
        public void TryParse()
        {
            EnumForBenchmarkA value;
            Enum<EnumForBenchmarkA>.TryParse("A", out value);
        }

        [Benchmark]
        public void TryParse_IgnoreCase_Nullable()
        {
            EnumForBenchmarkA? value;
            Enum<EnumForBenchmarkA>.TryParse("a", true, out value);
        }

        [Benchmark]
        public void TryParse_IgnoreCase()
        {
            EnumForBenchmarkA value;
            Enum<EnumForBenchmarkA>.TryParse("a", true, out value);
        }
        #endregion

        #region Nested type: EnumForBenchmarkA
        private enum EnumForBenchmarkA
        {
            A,
            B,
            C,
            D,
            E
        }
        #endregion

        #region Nested type: EnumForBenchmarkB
        private enum EnumForBenchmarkB
        {
            A,
            B,
            C,
            D,
            E
        }
        #endregion
    }
}