using Microsoft.AspNetCore.Mvc;

namespace HRIS.WebApi.Controllers.v1
{
    #region DailyRecords v1
    /// <summary>
    /// Daily Records Api
    /// </summary>
    [ApiVersion("1.0")]
    public class DailyRecordController : BaseApiController
    {
        private readonly IDailyRecordService _dailyRecordService;

        public DailyRecordController(IDailyRecordService dailyRecordService)
        {
            _dailyRecordService = dailyRecordService;
        }

        [HttpGet("getEmployeeNames")]
        [AllowAnonymous]
        public async Task<IActionResult> GetNameList()
        {
            return Ok(await _dailyRecordService.GetNameListAsync());
        }

        [HttpGet("getEmployeeRecords")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRecords(DailyRecordsSearchRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordSearchDto>(model);

            return Ok(await _dailyRecordService.GetRecordsAsync(requestDto));
        }
    }
    #endregion
}
