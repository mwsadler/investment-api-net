using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Common;

[ExcludeFromCodeCoverage]
public static class StartupExtension
{
    public static void AddCommonConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        
    }
}