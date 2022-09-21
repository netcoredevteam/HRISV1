using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;

namespace HRIS.Repository.Interfaces
{
    public interface IScheduleRepository : IDeleter<Schedule>,
                                           IInserter<Schedule>,
                                           IListRetriever<Schedule>,
                                           IRetriever<Schedule, Guid>,
                                           IUpdater<Schedule>
    {
        Task<Guid> GetIdAsync(string? scheduleName);
    }
}
