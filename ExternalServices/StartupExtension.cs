using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExternalServices;

[ExcludeFromCodeCoverage]
public static class StartupExtension
{
    public static void AddExternalServicesConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        
    }
}