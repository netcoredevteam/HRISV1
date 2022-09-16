using AutoMapper;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;

namespace HRIS.Service.Implementations
{
    public class ProfileService : IProfileService
    {
        #region Object & Constructor
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMandatoryRepository _mandatoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public ProfileService(IEmployeeRepository employeeRepository,
                                IMandatoryRepository mandatoryRepository,
                                IUserRepository userRepository,
                                IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mandatoryRepository = mandatoryRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }
        #endregion

        //Get Profile by EmployeeNo
        public async Task<ProfileDto> GetAsync(string employeeNo)
        {
            var profileDto = new ProfileDto();

            try
            {
                var employee = await _employeeRepository.GetByEmployeeNoAsync(employeeNo);

                var mandatory = await _mandatoryRepository.GetByEmployeeIdAsync(employee.Id);

                var user = await _userRepository.GetByEmployeeIdAsync(employee.Id);

                profileDto = new ProfileDto()
                {
                    EmployeeNo = employeeNo,
                    Username = user == null ? "no username" : user.Username,
                    DateHired = employee.DateHired,
                    YearsOfService = (int?)(DateTime.Now - employee.DateHired).TotalDays,
                    Birthday = employee.BirthDate,
                    Address = employee.Address,
                    Phone = employee.Phone,
                    ContactName = employee.ContactName,
                    ContactNo = employee.ContactNo,
                    Sss = mandatory.SSS,
                    PagIbig = mandatory.PagIbig,
                    PhilHealth = mandatory.PhilHealth,
                    Tin = mandatory.TIN,
                    Hmo = mandatory.HMO
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
