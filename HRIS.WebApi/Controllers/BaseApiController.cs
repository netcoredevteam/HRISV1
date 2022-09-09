using HRIS.WebApi.Attributes;
using Microsoft.AspNetCore.Mvc;

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
    }
    #endregion
}
