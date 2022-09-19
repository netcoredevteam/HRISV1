﻿using HRIS.Service.Exceptions;
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
            try
            {
                return Ok(await _whitelistService.GetAllAsync());
            }
            catch (ListNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
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
        public async Task<IActionResult> CreateWhitelist([FromBody] WhitelistDto model)
        {
            await _whitelistService.CreateAsync(model);
            return Ok();
        }

        #endregion

        #region Update
        /// <summary>
        /// Update Whitelist
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateWhitelist(Guid id, [FromBody] WhitelistDto model)
        {
            await _whitelistService.UpdateAsync(id, model);
            return Ok();
        }

        #endregion

        #region Delete
        /// <summary>
        /// Delete Whitelist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteWhitelist(Guid id)
        {
            var whitelist = await _whitelistService.GetAsync(id);
            await _whitelistService.RemoveAsync(whitelist);
            return Ok();
        }

        #endregion
    }
    #endregion
}
