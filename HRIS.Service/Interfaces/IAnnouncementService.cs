using HRIS.Domain.Entities;
using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IAnnouncementService
    {
        Task CreateAsync(Announcement announcement);//Create Announcement
        Task<IEnumerable<AnnouncementDto>> GetAllAsync();//Get All Announcement
    }
}
