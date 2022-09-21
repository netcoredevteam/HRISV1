namespace HRIS.WebApi.Controllers.v1
{
    #region ProfileController V1
    /// <summary>
    /// Profile Api
    /// </summary>
    [ApiVersion("1.0")]
    public class ProfileController : BaseApiController
    {
        private readonly IProfileService _profileService;

        /// <summary>
        /// Profile DI
        /// </summary>
        /// <param name="profileService"></param>
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        #region Get Profile
        /// <summary>
        /// Get Single Profile
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var profile = await _profileService.GetAsync(id);

            if (profile == null)
            {
                return NotFound(ResponseMessage.NotFound);
            }

            return Ok(profile);
        }
        #endregion

    }
    #endregion
}
