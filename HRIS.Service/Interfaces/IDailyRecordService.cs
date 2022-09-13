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
        Task<List<DailyRecordDto>> GetRecordsAsync(DailyRecordSearchDto model);
        Task CreateRecordAsync(DailyRecordDto model);
        Task UpdateRecordAsync(DailyRecordDto model);
        Task RemoveRecordAsync(Guid id);
    }
}
