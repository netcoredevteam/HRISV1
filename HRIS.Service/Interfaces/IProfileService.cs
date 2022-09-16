using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IProfileService
    {
        Task<ProfileDto> GetAsync(string employeeNo);
    }
}
