using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;

namespace firstWebAPI.Services
{
    public interface ITokenService
    {
        Task<string> GetTokenAsync();
    }

    public class HttpContextTokenService : ITokenService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly string bearer = "Bearer";

        public HttpContextTokenService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public Task<string> GetTokenAsync()
        {
            var token = httpContextAccessor.HttpContext?.Request?.Headers["Authorization"].ToString().Trim() ??
                        string.Empty;
            if (token.StartsWith(bearer, StringComparison.InvariantCultureIgnoreCase))
            {
                token = token.Remove(0, bearer.Length).Trim();
            }

            return Task.FromResult(token);
        }
    }
}
