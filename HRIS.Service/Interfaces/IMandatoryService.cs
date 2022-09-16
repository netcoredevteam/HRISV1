using HRIS.Domain.Entities;
using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IMandatoryService
    {
        Task<IEnumerable<MandatoryDto>> GetAllAsync();
        Task CreateAsync(Mandatory mandatory);
        Task CreateRangeAsync(List<Mandatory> mandatories);

        Task<Mandatory> GetAsync(Guid id);

        Task UpdateAsync();

    }
}
