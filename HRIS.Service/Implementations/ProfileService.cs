using AutoMapper;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;

namespace HRIS.Service.Implementations
{
    public class ProfileService : IProfileService
    {
        #region DI
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public ProfileService(IEmployeeRepository employeeRepository,
                                IUserRepository userRepository,
                                IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }
        #endregion

        //Get Profile by EmployeeId
        public async Task<ProfileDto?> GetAsync(Guid id)
        {
            var profileDto = new ProfileDto();

            try
            {
                var employee = await _employeeRepository.GetAsync(id);

                if (employee == null)
                {
                    return null;
                }

                var user = await _userRepository.GetByEmployeeIdAsync(employee.Id);

                profileDto = new ProfileDto()
                {
                    EmployeeNo = employee.EmployeeNo,
                    Username = user == null ? "no username" : user.Username,
                    DateHired = employee.DateHired,
                    YearsOfService = (int?)(DateTime.Now - employee.DateHired).TotalDays,
                    Birthday = employee.BirthDate,
                    Address = employee.Address,
                    Phone = employee.Phone,
                    ContactName = employee.ContactName,
                    ContactNo = employee.ContactNo,
                    Sss = employee.Mandatory?.SSS,
                    PagIbig = employee.Mandatory?.PagIbig,
                    PhilHealth = employee.Mandatory?.PhilHealth,
                    Tin = employee.Mandatory?.TIN,
                    Hmo = employee.Mandatory?.HMO
                };
            }
            catch (Exception)
            {
                throw;
            }

            return profileDto;
        } 
    }
}
