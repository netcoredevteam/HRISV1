using HRIS.Domain.Entities;
using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface ILeaveRecordService
    {
        Task<IEnumerable<LeaveRecordDto>> GetAllAsync();//Get All LeaveRecord
        Task CreateAsync(LeaveRecord leaveRecord);//Create LeaveRecord

    }
}
