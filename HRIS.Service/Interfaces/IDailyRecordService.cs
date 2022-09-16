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
        Task<List<DailyRecordDto>> SearchAsync(DailyRecordSearchDto model);
        Task<DailyRecordDto> GetAsync(Guid id);
        Task CreateAsync(DailyRecordDto model);
        Task UpdateAsync(DailyRecordDto model);
        Task RemoveAsync(DailyRecordDto model);
    }
}
