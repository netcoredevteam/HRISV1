using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IWhitelistService
    {
        Task<List<WhitelistDto>> GetAllAsync();
        Task CreateAsync(WhitelistDto model);
        Task UpdateAsync(WhitelistDto model);
        Task RemoveAsync(Guid id);
    }
}
