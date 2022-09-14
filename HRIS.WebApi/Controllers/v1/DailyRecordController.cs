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

        [HttpGet("GetEmployeeNames")]
        [AllowAnonymous]
        public async Task<IActionResult> GetNameList()
        {
            return Ok(await _dailyRecordService.GetNameListAsync());
        }

        [HttpGet("GetEmployeeRecords")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRecords([FromBody] DailyRecordsSearchRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordSearchDto>(model);

            return Ok(await _dailyRecordService.GetAsync(requestDto));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRecord([FromBody] DailyRecordsRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordDto>(model);
            await _dailyRecordService.CreateAsync(requestDto);
            return Ok();
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteRecord([FromBody] Guid id)
        {
            await _dailyRecordService.RemoveAsync(id);
            return Ok();
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateRecord([FromBody] DailyRecordsRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordDto>(model);
            await _dailyRecordService.UpdateAsync(requestDto);
            return Ok();
        }
    }
    #endregion
}
