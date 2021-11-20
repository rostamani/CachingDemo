using Domain.Core.Providers.Cache.Service;
using Infra.Cache.DistributedCache.Helper;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infra.Cache.DistributedCache.Implementation
{
    public class RedisCache : ICache
    {
        private readonly IDistributedCache _distributedCache;
        public RedisCache(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }
        public async Task<T> GetAsync<T>(string key, CancellationToken token = default) where T : class
        {
            var bytes = await _distributedCache.GetAsync(key,token);
            return bytes.FromByteArray<T>();
        }

        public async Task RemoveAsync(string key, CancellationToken token = default)
        {
            await _distributedCache.RemoveAsync(key, token);
        }

        public async Task SetAsync<T>(string key, T value, DistributedCacheEntryOptions options, CancellationToken token = default)
        {
            await _distributedCache.SetAsync(key, value.ToByteArray(), options, token);
        }
    }
}
