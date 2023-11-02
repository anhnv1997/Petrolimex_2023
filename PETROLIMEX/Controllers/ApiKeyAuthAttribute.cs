using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace iParking.Object
{
    public class ApiKeyMiddleware
    {
        public const string APIKeyToCheck = "Petro123456";
        private readonly RequestDelegate _next;
        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
            
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue("APIKey", out var apiRequestKey))
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Forbidden");
                return;
            }
            if (!APIKeyToCheck.Equals(apiRequestKey))
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Forbidden");
                return;
            }
            await _next(context);
        }
    }
}