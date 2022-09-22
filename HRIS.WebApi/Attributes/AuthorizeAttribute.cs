namespace HRIS.WebApi.Attributes
{
    #region Authorize Attribute
    /// <summary>
    /// Creates authorization based on defined role
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public List<string>? Roles { get; set; }

        /// <summary>
        /// Add role types
        /// </summary>
        /// <param name="roles"></param>
        public AuthorizeAttribute(params string[] roles)
        {
            this.Roles = roles.ToList();
        }

        /// <summary>
        /// Middleware use
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // Authorization
            var user = (User?)context.HttpContext.Items["User"];

            if (user == null || !this.Roles.Contains(user.Role))
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    } 
    #endregion
}
