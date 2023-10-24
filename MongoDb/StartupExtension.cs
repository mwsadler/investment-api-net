using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MongoDb;

[ExcludeFromCodeCoverage]
public static class StartupExtension
{
    public static void AddMongoDbConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        
    }
}