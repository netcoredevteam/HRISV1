using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Repository.Implementations;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;
using HRIS.Utility.Helpers;

namespace HRIS.Service.Implementations
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMapper _mapper;

        public ScheduleService(IScheduleRepository scheduleRepository,
            IMapper mapper)
        {
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(Schedule schedule)
        {
            await _scheduleRepository.InsertAsync(schedule);
            await _scheduleRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<ScheduleDto>> GetAllAsync()
        {
            var schedulesDtos = new List<ScheduleDto>();

            try
            {
                var schedules = await _scheduleRepository.GetAllAsync();


                foreach (var schedule in schedules)
                {

                    var scheduleDto = new ScheduleDto()
                    {
                        Name = schedule.Name,
                        StartTime = schedule.StartTime,
                        EndTime = schedule.EndTime
                    };

                    schedulesDtos.Add(scheduleDto);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return schedulesDtos;
        }

        public async Task<ScheduleDto?> GetAsync(Guid id)
        {
            var scheduleDto = new ScheduleDto();

            try
            {
                var schedule = await _scheduleRepository.GetAsync(id);

                if (schedule == null)
                {
                    return null;
                }

                scheduleDto = new ScheduleDto() 
                {
                    Name = schedule.Name,
                    StartTime = schedule.StartTime,
                    EndTime = schedule.EndTime
                };

            }
            catch (Exception)
            {
                throw;
            }

            return scheduleDto;
        }

        public async Task<bool> HasDuplicateAsync(string scheduleName)
        {
            return await _scheduleRepository.HasDuplicateAsync(scheduleName);
        }
    }
}
