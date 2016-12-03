using System;
using System.Collections.Generic;
using System.Text;

namespace Catel.Benchmarks.Caching
{
    using BenchmarkDotNet.Attributes;
    using Catel.Caching;
    using Catel.Caching.Policies;

    public class CacheStorage_Benchmack
    {
        private CacheStorage<int, int> initializedCacheStorage;

        private CacheStorage<int, int> cacheStorageNonExpirationPolicy;

        private CacheStorage<int, int> cacheStorageExpirationPolicy;

        private Random random;

        const int MaxValue = 15;


        [Setup]
        public void Init()
        {
            random = new Random();

            initializedCacheStorage = new CacheStorage<int, int>();
            for (int i = 0; i < MaxValue; i++)
            {
                initializedCacheStorage.GetFromCacheOrFetch(i, () => 0);
            }

            cacheStorageNonExpirationPolicy = new CacheStorage<int, int>();

            cacheStorageExpirationPolicy = new CacheStorage<int, int>(() => ExpirationPolicy.Duration(TimeSpan.Zero, true));
         }

        [Benchmark]
        public void GetValue_From_An_Already_Initialized_Cache()
        {
            initializedCacheStorage.Get(random.Next(0, MaxValue));
        }

        [Benchmark]
        public void GetFromCacheOrFetch()
        {
            cacheStorageNonExpirationPolicy.GetFromCacheOrFetch(random.Next(0, MaxValue), () => 0);
        }

        [Benchmark]
        public void GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy()
        {
            cacheStorageExpirationPolicy.GetFromCacheOrFetch(random.Next(0, MaxValue), () => 0);
        }
       
    }
}
