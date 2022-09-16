using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;
using HRIS.Domain.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IWorkPositionRepository : IDeleter<WorkPosition>,
                                           IInserter<WorkPosition>,
                                           IListRetriever<WorkPosition>,
                                           IRetriever<WorkPosition, Guid>,
                                           IUpdater<WorkPosition>
    {
        Task<WorkPosition> GetAsync(string workCode);
        Task<Guid> GetIdAsync(string workCode);
    }
}
