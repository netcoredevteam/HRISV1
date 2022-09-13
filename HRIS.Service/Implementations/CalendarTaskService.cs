using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;

namespace HRIS.Service.Implementations
{
    public class CalendarTaskService : ICalendarTaskService
    {
        #region Object & Constructor
        private readonly ICalendarTaskRepository _calendarTaskRepository;
        private readonly IMapper _mapper;

        public CalendarTaskService(ICalendarTaskRepository calendarTaskRepository, IMapper mapper)
        {
            _calendarTaskRepository = calendarTaskRepository;
            _mapper = mapper;
        }
        #endregion

        //Create CalendarTask
        public async Task CreateAsync(CalendarTask calendarTask)
        {
            await _calendarTaskRepository.InsertAsync(calendarTask);
            await _calendarTaskRepository.SaveChangesAsync();
        }

        //Get All CalendarTask
        public async Task<IEnumerable<CalendarTaskDto>> GetAllAsync()
        {
            var calendarTaskDtos = new List<CalendarTaskDto>();

            try
            {
                var calendarTasks = await _calendarTaskRepository.GetAllAsync();

                foreach (var calendarTask in calendarTasks)
                {

                    var calendarTaskDto = new CalendarTaskDto()
                    {
                        Title = calendarTask.Title,
                        Description = calendarTask.Description,
                        DateTask = calendarTask.DateTask,
                        CreatedBy = calendarTask.CreatedBy
                    };

                    calendarTaskDtos.Add(calendarTaskDto);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return calendarTaskDtos;
        }
    }
}
