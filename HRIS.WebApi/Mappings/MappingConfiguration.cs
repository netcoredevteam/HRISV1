using AutoMapper;

namespace HRIS.WebApi.Mappings
{
    public class ControllerMappingProfile : Profile
    {
        public ControllerMappingProfile()
        {
            CreateMap<DailyRecordDto, DailyRecordsRequestModel>().ReverseMap();
        }
    }
}
