using HRIS.Repository.Interfaces;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public class DistributedCacheRepository<T> : IDistributedCacheRepository<T> where T : class
    {
        private readonly IDistributedCache _cache;

        public DistributedCacheRepository(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<T> GetCachedAsync(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                byte[] cachedData = await _cache.GetAsync(key);

                if (cachedData != null)
                {
                    MemoryStream stream = new(cachedData);
                    T item = JsonSerializer.Deserialize<T>(stream);
                    stream.Close();

                    return item;
                }

                return null;
            }
            else
            {
                throw new ArgumentNullException("Cache key can't be null");
            }
        }

        public async Task RefreshCacheAsync(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                await _cache.RefreshAsync(key);
            }
        }

        public async Task RemoveCacheAsync(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                await _cache.RemoveAsync(key);
            }
        }

        public async Task SetCacheAsync(string key, T entity, TimeSpan expiry)
        {
            if (entity != null && !string.IsNullOrEmpty(key))
            {
                var options = new DistributedCacheEntryOptions().SetSlidingExpiration(expiry);
                await _cache.SetAsync(key, JsonSerializer.SerializeToUtf8Bytes(entity), options);
            }
            else
            {
                throw new ArgumentNullException("Set cache can't have null values.");
            }
        }
    }
}
