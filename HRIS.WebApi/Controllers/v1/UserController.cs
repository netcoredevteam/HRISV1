using HRIS.Service.Exceptions;
using System.Net.Http.Headers;

namespace HRIS.WebApi.Controllers.v1
{
    #region Users Api
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        #region Dependency Injection
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService, HttpClient httpClient)
        {
            _userService = userService;
            _httpClient = httpClient;
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
                var authModel = await _userService.AuthenticateAsync(model.Username, model.Password);
                _httpClient.DefaultRequestHeaders.Add("Authentication", $"Bearer {authModel.Token}");
                return Ok(authModel);
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
