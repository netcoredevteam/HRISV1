using AutoMapper;

namespace HRIS.WebApi.Mappings
{
    public class ControllerMappingProfile : Profile
    {
        public ControllerMappingProfile()
        {
            CreateMap<DailyRecordDto, DailyRecordsRequestModel>().ReverseMap();

            CreateMap<WhitelistDto, CreateWhitelistRequestModel>().ReverseMap();
            CreateMap<WhitelistDto, UpdateWhitelistRequestModel>().ReverseMap();

            CreateMap<UserDto, CreateUserRequestModel>().ReverseMap();
        }
    }
}
