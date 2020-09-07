using Microsoft.AspNetCore.Builder;
using MobileApp.Helper.Middleware;

namespace MobileApp.Helper.MiddlewareExtension
{
    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddeware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
