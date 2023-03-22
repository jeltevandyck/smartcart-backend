using System.Text.Json;
using EPS.Smartcart.Application.Exceptions;
using EPS.Smartcart.Domain.Exceptions;

namespace EPS.Smartcart.API.Middleware;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    
    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            ErrorResponse errorResponse = new ErrorResponse();
            switch (ex)
            {
                case ValidationException:
                    errorResponse.StatusCode = StatusCodes.Status422UnprocessableEntity;
                    errorResponse.Errors = ((ValidationException) ex).Errors;
                    break;
                default:
                    errorResponse.StatusCode = StatusCodes.Status500InternalServerError;
                    errorResponse.Errors = new List<Error> { new ("Internal Server Error", ex.Message)};
                    break;
            }
            
            context.Response.StatusCode = errorResponse.StatusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
        }
    }
}