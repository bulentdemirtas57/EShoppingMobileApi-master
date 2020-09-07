using Microsoft.AspNetCore.Builder;
using MobileApp.Helper.Middleware;

namespace MobileApp.Helper.MiddlewareExtension
{
    public static class ResponseWrapperExtensions
    {
        public static IApplicationBuilder UseResponseWrapper(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseWrapper>();
        }
    }
}
