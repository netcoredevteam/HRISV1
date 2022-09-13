using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Repository.Implementations;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;

namespace HRIS.Service.Implementations
{
    public class LeaveRecordService : ILeaveRecordService
    {
        #region Object & Constructor

        private readonly ILeaveRecordRepository _leaveRecordRepository;
        private readonly IMapper _mapper;

        public LeaveRecordService(ILeaveRecordRepository leaveRecordRepository,
            IMapper mapper)
        {
            _leaveRecordRepository = leaveRecordRepository;
            _mapper = mapper;
        }

        #endregion

        //Create LeaveRecord
        public async Task CreateAsync(LeaveRecord leaveRecord)
        {
            await _leaveRecordRepository.InsertAsync(leaveRecord);
            await _leaveRecordRepository.SaveChangesAsync();
        }

        //Get All LeaveRecord
        public async Task<IEnumerable<LeaveRecordDto>> GetAllAsync()
        {
            var leaveRecordDtos = new List<LeaveRecordDto>();

            try
            {
                var leaveRecords = await _leaveRecordRepository.GetAllAsync();

                foreach (var leaveRecord in leaveRecords)
                {

                    var leaveRecordDto = new LeaveRecordDto()
                    {
                        EmployeeId = leaveRecord.Id,
                        Status = leaveRecord.Status, 
                        FiledDate = leaveRecord.FiledDate,
                        DateLeaveFrom = leaveRecord.LeaveStartDate,
                        DateLeaveTo = leaveRecord.LeaveEndDate,
                        Reason = leaveRecord.ReasonOfLeave,
                        UserId = leaveRecord.UserId,
                        Remarks = leaveRecord.Remarks,
                        LeaveType = leaveRecord.Leavetype
                    };

                    leaveRecordDtos.Add(leaveRecordDto);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return leaveRecordDtos;
        }
    }
}
