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
        Task<WhitelistDto> GetAsync(Guid id);
        Task CreateAsync(WhitelistDto model);
        Task UpdateAsync(Guid id, WhitelistDto model);
        Task RemoveAsync(WhitelistDto model);
    }
}
