// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CacheStorage_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Caching
{
    using System;
    using BenchmarkDotNet.Attributes;
    using Catel.Caching;
    using Catel.Caching.Policies;

    public class CacheStorage_Benchmark
    {
        #region Constants
        const int MaxValue = 15;
        #endregion

        #region Fields
        private CacheStorage<int, int> _cacheStorageExpirationPolicy;

        private CacheStorage<int, int> _cacheStorageNonExpirationPolicy;
        private CacheStorage<int, int> _initializedCacheStorage;

        private Random _random;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            _random = new Random();

            _initializedCacheStorage = new CacheStorage<int, int>();
            for (int i = 0; i < MaxValue; i++)
            {
                _initializedCacheStorage.GetFromCacheOrFetch(i, () => 0);
            }

            _cacheStorageNonExpirationPolicy = new CacheStorage<int, int>();

            _cacheStorageExpirationPolicy = new CacheStorage<int, int>(() => ExpirationPolicy.Duration(TimeSpan.Zero, true));
        }

        [Benchmark]
        public void GetValue_From_An_Already_Initialized_Cache()
        {
            _initializedCacheStorage.Get(_random.Next(0, MaxValue));
        }

        [Benchmark]
        public void GetFromCacheOrFetch()
        {
            _cacheStorageNonExpirationPolicy.GetFromCacheOrFetch(_random.Next(0, MaxValue), () => 0);
        }

        [Benchmark]
        public void GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy()
        {
            _cacheStorageExpirationPolicy.GetFromCacheOrFetch(_random.Next(0, MaxValue), () => 0);
        }
        #endregion
    }
}