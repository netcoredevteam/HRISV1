using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface ILeaveRecordService
    {
        Task<IEnumerable<LeaveRecordDto>> GetAllAsync();
    }
}
