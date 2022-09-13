using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;

namespace HRIS.Repository.Interfaces
{
    public interface IAnnouncementRepository : IDeleter<Announcement>,
                                               IInserter<Announcement>,
                                               IListRetriever<Announcement>,
                                               IRetriever<Announcement, Guid>,
                                               IUpdater<Announcement>,
                                               IRepository
    {
    }
}
