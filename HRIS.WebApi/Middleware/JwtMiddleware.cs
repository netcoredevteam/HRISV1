using HRIS.Repository.Interfaces;
using HRIS.Service.Interfaces;

namespace HRIS.WebApi.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUserRepository userRepository, IJwtService jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = jwtUtils.ValidateToken(token);

            if (userId != null)
            {
                // attach user to context on successful jwt validation
                context.Items["User"] = await userRepository.GetAsync(userId.Value);
            }

            await _next(context);
        }
    }
}
