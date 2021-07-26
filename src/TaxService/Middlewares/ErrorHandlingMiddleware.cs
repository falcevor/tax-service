using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using TaxService.Application.Exceptions;

namespace TaxService.Middlewares
{
    public class ErrorHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (ApplicationException ex)
            {
                switch (ex)
                {
                    case NotFoundException:
                        context.Response.StatusCode = 404;
                        break;
                    default:
                        context.Response.StatusCode = 400;
                        break;
                }
            }
        }
    }
}
