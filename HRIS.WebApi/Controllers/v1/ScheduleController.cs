using HRIS.WebApi.Models.RequestModels.Authenticated.Schedule;

namespace HRIS.WebApi.Controllers.v1
{
    #region ScheduleController V1
    /// <summary>
    /// Schedule Api
    /// </summary>
    [ApiVersion("1.0")]
    public class ScheduleController : BaseApiController
    {
        private readonly IScheduleService _scheduleService;

        /// <summary>
        /// Schedule DI
        /// </summary>
        /// <param name="scheduleService"></param>
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        #region Get All Schedule
        /// <summary>
        /// Get All Schedule
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _scheduleService.GetAllAsync());
        }

        #endregion

        #region Get Schedule
        /// <summary>
        /// Get Single Schedule
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var schedule = await _scheduleService.GetAsync(id);

            if (schedule == null)
            {
                return NotFound(ResponseMessage.NotFound);
            }

            return Ok(schedule);
        }
        #endregion

        #region Create Schedule
        /// <summary>
        /// Creates an Schedule
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] InsertScheduleRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            var hasDuplicate = await _scheduleService.HasDuplicateAsync(model.Name);

            if (hasDuplicate)
            {
                return Conflict(ResponseMessage.DuplicateEmployeeNo);
            }

            var schedule = new Schedule();
            schedule.Id = Guid.NewGuid();
            schedule.Name = model.Name;
            schedule.StartTime = model.StartTime;
            schedule.EndTime = model.EndTime;
            schedule.Status = model.Status;
            schedule.CreatedBy = "System";
            schedule.CreatedAt = DateTime.Now;
            schedule.UpdatedAt = DateTime.Now;
            schedule.UpdatedBy = "System";

            await _scheduleService.CreateAsync(schedule);

            return Ok(ResponseMessage.Success);
        }
        #endregion

    }
    #endregion
}

