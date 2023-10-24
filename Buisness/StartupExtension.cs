using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Buisness;

[ExcludeFromCodeCoverage]
public static class StartupExtension
{
    public static void AddBusinessDomainConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        
    }
}