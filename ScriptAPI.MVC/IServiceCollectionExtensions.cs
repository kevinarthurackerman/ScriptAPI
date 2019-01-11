using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ScriptAPI.HostContext;
using ScriptAPI.MVC.ServiceConfiguration;
using ScriptAPI.Procedures;
using System;
using System.Linq;
using System.Reflection;

namespace ScriptAPI.MVC
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddScriptAPI(this IServiceCollection services) => AddScriptAPI(services, x => { });

        public static IServiceCollection AddScriptAPI(this IServiceCollection services, Action<OptionsBuilder> optionsBuilder)
        {
            var builder = new OptionsBuilder();
            optionsBuilder(builder);
            var options = builder.Build();

            services.AddSingleton<ScriptAPI.ServiceConfiguration.IOptions>(options);

            services.AddSingleton<ScriptAPIService>();

            var procedures = Assembly.GetEntryAssembly().GetTypes()
                    .Where(x => x.IsClass && !x.IsAbstract && typeof(IProcedure).IsAssignableFrom(x))
                    .ToArray();

            foreach (var procedure in procedures)
            {
                services.AddTransient(procedure);
            }

            services.AddSingleton(new ProcedureMapping(procedures.Select(x => (Name: x.Name, Type: x)).ToArray()));

            services.AddSingleton<ProcedureLocator>(serviceProvider => (Type type) => serviceProvider.GetRequiredService(type));

            services.AddSingleton(serviceProvider => new Host(
                serviceProvider.GetRequiredService<ProcedureLocator>(),
                serviceProvider.GetRequiredService<ProcedureMapping>())
              );

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
