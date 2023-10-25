using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDb.Respositories;
using MongoFramework;

namespace MongoDb;

[ExcludeFromCodeCoverage]
public static class StartupExtension
{
    public static void AddMongoDbConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IMongoDbConnection>(sp =>
            MongoDbConnection.FromConnectionString(configuration.GetConnectionString("BookStoreDbConnection")));
        services.AddTransient<MongoDbContext.MongoDbContext>();
        services.AddTransient<IUserRepository, UserRepository>();
    }
}