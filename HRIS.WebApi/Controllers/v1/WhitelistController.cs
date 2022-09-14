using Microsoft.AspNetCore.Mvc;

namespace HRIS.WebApi.Controllers.v1
{
    #region Whitelist Api
    /// <summary>
    /// Whitelist api
    /// </summary>
    [ApiVersion("1.0")]
    public class WhitelistController : BaseApiController
    {
        #region Dependency Injection
        private readonly IWhitelistService _whitelistService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="whitelistService"></param>
        public WhitelistController(IWhitelistService whitelistService)
        {
            _whitelistService = whitelistService;
        } 
        #endregion

        #region GetAll
        /// <summary>
        /// Gets all whitelist
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllWhitelist()
        {
            return Ok(await _whitelistService.GetAllAsync());
        }

        #endregion

        #region Create
        /// <summary>
        /// Create Whitelist
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateWhitelist([FromBody] CreateWhitelistRequestModel model)
        {
            var whitelistDto = Mapper.Map<WhitelistDto>(model);
            await _whitelistService.CreateAsync(whitelistDto);
            return Ok();
        }

        #endregion

        #region Update
        /// <summary>
        /// Update Whitelist
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateWhitelist([FromBody] UpdateWhitelistRequestModel model)
        {
            var whitelistDto = Mapper.Map<WhitelistDto>(model);
            await _whitelistService.UpdateAsync(whitelistDto);
            return Ok();
        }

        #endregion

        #region Delete
        /// <summary>
        /// Delete Whitelist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteWhitelist([FromBody] Guid id)
        {
            await _whitelistService.RemoveAsync(id);
            return Ok();
        }

        #endregion
    }
    #endregion
}
