using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ScriptAPI.MVC.PipelineConfiguration;
using System;

namespace ScriptAPI.MVC
{
    public static class IApplicationBuilderExtensions
    {
        private static readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        public static IApplicationBuilder UseScriptAPI(this IApplicationBuilder app) => UseScriptAPI(app, x => { });

        public static IApplicationBuilder UseScriptAPI(this IApplicationBuilder app, Action<OptionsBuilder> optionsBuilder)
        {
            var builder = new OptionsBuilder();
            optionsBuilder(builder);
            var options = builder.Build();
            
            app.MapWhen(
                (HttpContext httpContext) => httpContext.Request.Path.StartsWithSegments(options.EndpointPath, StringComparison.OrdinalIgnoreCase),
                (IApplicationBuilder appBuilder) =>
                {
                    appBuilder.Run(async (HttpContext httpContext) =>
                    {
                        var scriptApiService = httpContext.RequestServices.GetRequiredService<ScriptAPIService>();
                        var result = await scriptApiService.ExecuteAsync(httpContext.Request.Body);
                        var resultJson = JsonConvert.SerializeObject(result, _jsonSerializerSettings);
                        await httpContext.Response.WriteAsync(resultJson);
                    });
                });

            return app;
        }
    }
}
