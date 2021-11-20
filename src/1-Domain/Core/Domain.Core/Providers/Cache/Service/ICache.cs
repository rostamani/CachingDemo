using Microsoft.Extensions.Caching.Distributed;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Core.Providers.Cache.Service
{
    public interface ICache
    {
        Task SetAsync<T>(string key, T value, DistributedCacheEntryOptions options, CancellationToken token = default);
        Task<T> GetAsync<T>(string key, CancellationToken token = default) where T : class;
        Task RemoveAsync(string key, CancellationToken token = default);
    }
}
