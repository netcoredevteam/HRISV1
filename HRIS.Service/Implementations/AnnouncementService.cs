using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;

namespace HRIS.Service.Implementations
{
    public class AnnouncementService : IAnnouncementService
    {
        #region Object & Constructor
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IMapper _mapper;

        public AnnouncementService(IAnnouncementRepository announcementRepository, IMapper mapper)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }
        #endregion

        //Create Announcement
        public async Task CreateAsync(Announcement announcement)
        {
            await _announcementRepository.InsertAsync(announcement);
            await _announcementRepository.SaveChangesAsync();
        }

        //Get All Announcement
        public async Task<IEnumerable<AnnouncementDto>> GetAllAsync()
        {
            var announcementsDtos = new List<AnnouncementDto>();

            try
            {
                var announcements = await _announcementRepository.GetAllAsync();

                foreach (var announcement in announcements)
                {

                    var announcementDto = new AnnouncementDto()
                    {
                        Title = announcement.Title,
                        Message = announcement.Message,
                        CreatedBy = announcement.CreatedBy
                    };

                    announcementsDtos.Add(announcementDto);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return announcementsDtos;
        }
    }
}
