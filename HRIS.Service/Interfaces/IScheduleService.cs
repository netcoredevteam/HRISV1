using HRIS.Domain.Entities;
using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IScheduleService
    {
        Task<IEnumerable<ScheduleDto>> GetAllAsync();
        Task<ScheduleDto> GetAsync(Guid id); //For getting single schedule
        Task CreateAsync(Schedule schedule);
        Task<bool> HasDuplicateAsync(string scheduleName);

    }
}
