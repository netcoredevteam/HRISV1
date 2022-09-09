namespace HRIS.WebApi.Controllers
{
    #region BaseController
    /// <summary>
    /// Base Api Controller
    /// </summary>
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
    }
    #endregion
}
