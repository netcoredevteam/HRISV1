using HRIS.Domain.Entities;
using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface ICalendarTaskService 
    {
        Task CreateAsync(CalendarTask calendarTask);//Create CalendarTask
        Task<IEnumerable<CalendarTaskDto>> GetAllAsync();//Get All CalendarTask
    }
}
