using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
            CreateMap<User, UserEmployeeDto>().IncludeMembers(s => s.Employee);
            CreateMap<Employee, UserEmployeeDto>(MemberList.None);

            CreateMap<Mandatory, MandatoryDto>().ReverseMap();
            CreateMap<LeaveRecord, LeaveRecordDto>().ReverseMap();
            CreateMap<Schedule, ScheduleDto>().ReverseMap();
            CreateMap<WorkPosition, WorkPositionDto>().ReverseMap();
        }
    }
}
