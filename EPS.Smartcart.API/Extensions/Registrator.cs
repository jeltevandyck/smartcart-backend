using Microsoft.AspNetCore.Diagnostics;

namespace EPS.Smartcart.API.Extensions;

public static class Registrator
{
    public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionHandlerMiddleware>();
        return app;
    }
}