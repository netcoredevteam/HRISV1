using HRIS.Service.Exceptions;

namespace HRIS.WebApi.Controllers.v1
{
    #region Users Api
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        #region Dependency Injection
        private readonly IUserService _userService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Login User
        /// <summary>
        /// User Login
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequestModel model)
        {
            try
            {
                return Ok(await _userService.AuthenticateAsync(model.Username, model.Password));
            }
            catch (UserNotFoundException ex)
            {
                return Unauthorized(ex.Message);
            }
        }
        #endregion

        #region Create User
        /// <summary>
        /// Creates User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestModel model)
        {
            var userDto = Mapper.Map<UserDto>(model);
            await _userService.CreateAsync(userDto);
            return Ok();
        } 
        #endregion
    } 
    #endregion
}
