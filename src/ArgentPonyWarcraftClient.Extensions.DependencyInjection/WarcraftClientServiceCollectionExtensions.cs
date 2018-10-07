using System;
using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Options;

namespace ArgentPonyWarcraftClient.Extensions.DependencyInjection
{
    public static class WarcraftClientServiceCollectionExtensions
    {
        public static IServiceCollection UseWarcraftClient(this IServiceCollection services)
        {
            services.AddOptions<WarcraftClientOptions>();
            services.AddScoped<WarcraftClientOptions>(s => s.GetService<IOptions<WarcraftClientOptions>>().Value);

            services.AddHttpClient<IWarcraftClient, WarcraftClient>()
                .ConfigureHttpClient(client =>
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                });

            return services;
        }
    }
}
