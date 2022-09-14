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
        #region Dependency Injection
        private readonly IDailyRecordService _dailyRecordService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dailyRecordService"></param>
        public DailyRecordController(IDailyRecordService dailyRecordService)
        {
            _dailyRecordService = dailyRecordService;
        } 
        #endregion

        #region Get list of names
        /// <summary>
        /// Get name list
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetEmployeeNames")]
        [AllowAnonymous]
        public async Task<IActionResult> GetNameList()
        {
            return Ok(await _dailyRecordService.GetNameListAsync());
        }
        #endregion

        #region GetRecords
        /// <summary>
        /// Get records
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet("GetEmployeeRecords")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRecords([FromBody] DailyRecordsSearchRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordSearchDto>(model);

            return Ok(await _dailyRecordService.GetAsync(requestDto));
        }
        #endregion

        #region Create Record
        /// <summary>
        /// Create record
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRecord([FromBody] DailyRecordsRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordDto>(model);
            await _dailyRecordService.CreateAsync(requestDto);
            return Ok();
        }
        #endregion

        #region DeleteRecord
        /// <summary>
        /// Remove record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteRecord([FromBody] Guid id)
        {
            await _dailyRecordService.RemoveAsync(id);
            return Ok();
        }
        #endregion

        #region UpdateRecord
        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateRecord([FromBody] DailyRecordsRequestModel model)
        {
            var requestDto = Mapper.Map<DailyRecordDto>(model);
            await _dailyRecordService.UpdateAsync(requestDto);
            return Ok();
        } 
        #endregion
    }
    #endregion
}
