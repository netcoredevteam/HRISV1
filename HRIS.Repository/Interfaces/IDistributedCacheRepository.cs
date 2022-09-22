using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IDistributedCacheRepository<T> where T : class
    {
        Task<T> GetCachedAsync(string key);
        Task SetCacheAsync(string key, T entity, TimeSpan expiry);
        Task RefreshCacheAsync(string key);
        Task RemoveCacheAsync(string key);
    }
}
