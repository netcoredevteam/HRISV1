namespace HRIS.WebApi.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, 
                                 IUserRepository userRepository, 
                                 IJwtService jwtUtils,
                                 IDistributedCacheRepository<string> distributedCacheRepository)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var userId = jwtUtils.ValidateToken(token);

            if (userId != null)
            {
                var tokenCache = await distributedCacheRepository.GetCachedAsync(userId.ToString());

                if (!string.IsNullOrEmpty(tokenCache))
                {
                    context.Items["User"] = await userRepository.GetAsync(userId.Value);
                }
            }

            await _next(context);
        }
    }
}
