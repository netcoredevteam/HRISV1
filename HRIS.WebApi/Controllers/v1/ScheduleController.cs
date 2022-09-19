namespace HRIS.WebApi.Controllers.v1
{
    #region ScheduleController V1
    /// <summary>
    /// Schedule Api
    /// </summary>
    [ApiVersion("1.0")]
    public class ScheduleController : ControllerBase
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

    }
    #endregion
}
