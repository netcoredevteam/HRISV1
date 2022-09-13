using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IDailyRecordRepository : IDeleter<DailyRecord>,
                                           IInserter<DailyRecord>,
                                           IListRetriever<DailyRecord>,
                                           IRetriever<DailyRecord, Guid>,
                                           IUpdater<DailyRecord>,
                                           ISaver
    {
        Task<IEnumerable<DailyRecord>> GetAllByEmployeeNoAsync(string? employeeNo);
    }
}
