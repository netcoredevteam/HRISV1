using AutoMapper;

namespace HRIS.WebApi.Controllers
{
    #region BaseController
    /// <summary>
    /// Base Api Controller
    /// </summary>
    [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        private IMapper? _mapper;

        /// <summary>
        /// Automapper service
        /// </summary>
        protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetRequiredService<IMapper>();
    }
    #endregion
}
