using Microsoft.Extensions.DependencyInjection;

namespace BlazorHybrid.GTK;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorWebViewOptions(this IServiceCollection services, BlazorWebViewOptions options)
    {
        return services
            .AddBlazorWebView()
            .AddSingleton(options);
    }
}