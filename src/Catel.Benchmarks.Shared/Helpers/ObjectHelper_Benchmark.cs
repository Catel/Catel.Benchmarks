// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ObjectHelper_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ObjectHelper_Benchmark : BenchmarkBase
    {
        #region Fields
        private object _instanceA;
        private object _instanceB;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _instanceA = new object();
            _instanceB = new object();
        }

        [Benchmark]
        public void IsNull()
        {
            ObjectHelper.IsNull(null);
        }

        [Benchmark]
        public void AreEqualReferences_Both_Null()
        {
            ObjectHelper.AreEqualReferences(null, null);
        }

        [Benchmark]
        public void AreEqualReferences_One_Null()
        {
            ObjectHelper.AreEqualReferences(_instanceA, null);
        }

        [Benchmark]
        public void AreEqualReferences_Same_Reference()
        {
            ObjectHelper.AreEqualReferences(_instanceA, _instanceA);
        }

        [Benchmark]
        public void AreEqualReferences_Not_Same_Reference()
        {
            ObjectHelper.AreEqualReferences(_instanceA, _instanceB);
        }

        [Benchmark]
        public void AreEqualReferences_Strings()
        {
            ObjectHelper.AreEqualReferences("A", "B");
        }

        [Benchmark]
        public void AreEqual_Both_Null()
        {
            ObjectHelper.AreEqual(null, null);
        }

        [Benchmark]
        public void AreEqual_One_Null()
        {
            ObjectHelper.AreEqual(_instanceA, null);
        }

        [Benchmark]
        public void AreEqual__Same_Reference()
        {
            ObjectHelper.AreEqual(_instanceA, _instanceA);
        }

        [Benchmark]
        public void AreEqual_Not_Same_Reference()
        {
            ObjectHelper.AreEqual(_instanceA, _instanceB);
        }

        [Benchmark]
        public void AreEqual_Strings()
        {
            ObjectHelper.AreEqual("A", "B");
        }
        #endregion
    }
}