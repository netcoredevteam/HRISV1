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

        public async Task<IActionResult> LoginUser([FromBody] LoginRequestModel model)
        {
            var result = await _userService.AuthenticateUser(model.Username, model.Password);

            return Ok(result);
        }
    }
}
