using HRIS.Service.Interfaces;
using HRIS.WebApi.Attributes;
using HRIS.WebApi.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequestModel model)
        {
            var result = await _userService.AuthenticateUser(model.Username, model.Password);

            return Ok(result);
        }
    }
}
