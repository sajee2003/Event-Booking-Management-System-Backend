using System.Text.Json;
using EventBookingManagementSystem_Backend.DTOs.Common.Modal;

namespace EventBookingManagementSystem_Backend.DTOs.Common.MiddleWare
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public CustomExceptionMiddleware(RequestDelegate next, ILogger<CustomExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ArgumentException argEx)
            {
                _logger.LogWarning(argEx, "Bad Request: " + argEx.Message);
                await HandleExceptionAsync(context, StatusCodes.Status400BadRequest, argEx.Message, argEx.StackTrace);
            }
            catch (KeyNotFoundException keyEx)
            {
                _logger.LogWarning(keyEx, "Not Found: " + keyEx.Message);
                await HandleExceptionAsync(context, StatusCodes.Status404NotFound, keyEx.Message, keyEx.StackTrace);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, StatusCodes.Status500InternalServerError, "Internal Server Error", _env.IsDevelopment() ? ex.StackTrace : null);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, int statusCode, string message, string stackTrace = null)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = _env.IsDevelopment()
                ? new ApiException(statusCode, message, stackTrace)
                : new ApiException(statusCode, message);

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(response, options);
            await context.Response.WriteAsync(json);
        }
    }
}
