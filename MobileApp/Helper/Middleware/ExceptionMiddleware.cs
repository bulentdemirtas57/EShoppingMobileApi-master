using Microsoft.AspNetCore.Http;
using MobileApp.Core;
using System;
using System.Threading.Tasks;

namespace MobileApp.Helper.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string errorMessage = string.Empty;

            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                if (ex is ApiException)
                {
                    errorMessage = ex.Message;
                }
                else
                {
                    errorMessage = "Error";
                }

                context.Items.Add("exception", ex);
                context.Items.Add("exceptionMessage", errorMessage);
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }

        }
    }
}
