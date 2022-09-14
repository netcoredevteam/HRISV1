using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IDailyRecordService
    {
        Task<IEnumerable<EmployeeNameDto>> GetNameListAsync();
        Task<List<DailyRecordDto>> GetAsync(DailyRecordSearchDto model);
        Task CreateAsync(DailyRecordDto model);
        Task UpdateAsync(DailyRecordDto model);
        Task RemoveAsync(Guid id);
    }
}
