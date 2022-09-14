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
            var result = await _userService.AuthenticateAsync(model.Username, model.Password);

            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestModel model)
        {
            var userDto = Mapper.Map<UserDto>(model);
            await _userService.CreateAsync(userDto);
            return Ok();
        }
    }
}
