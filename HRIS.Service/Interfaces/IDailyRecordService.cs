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
        Task<IEnumerable<DailyRecordNameDto>> GetNameListAsync();
        Task<List<DailyRecordDto>> GetRecords(DailyRecordSearchDto model);
    }
}
