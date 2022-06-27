using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Text;

namespace Api.Extension.Exception
{
    public static class HttpGlobalExceptionFilter
    {
        /*powered by https://code-maze.com/global-error-handling-aspnetcore/ */
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
       {
            app.UseExceptionHandler(options => {
                options.Run(async context => {
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    context.Response.ContentType = "application/json";
                    var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                    if(null != exceptionObject)
                    {
                        var errorMessage = Encoding.UTF8.GetBytes($"{exceptionObject.Error.Message}");
                        await context.Response.Body.WriteAsync(errorMessage,0,errorMessage.Length);
                    }
                });
            });
       }
    }
}
