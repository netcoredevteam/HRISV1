using HRIS.Domain.Entities;
using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IWorkPositionService
    {
        Task<IEnumerable<WorkPositionDto>> GetAllAsync();
        Task<Guid> GetIdAsync(string workCode);
    }
}
