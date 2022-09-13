using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface ILeaveRecordRepository : IDeleter<LeaveRecord>,
                                           IInserter<LeaveRecord>,
                                           IListRetriever<LeaveRecord>,
                                           IRetriever<LeaveRecord, Guid>,
                                           IUpdater<LeaveRecord>,
                                           IRepository
    {
    }
}
