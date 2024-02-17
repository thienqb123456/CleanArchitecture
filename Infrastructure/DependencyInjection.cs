using Application.IRepositories;
using ApplicationCore.Databases.Definitions;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        //public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddNamed<DbFactory>(names =>
        //    {
        //        //names.AddScoped("MySql", _ => new DbFactory(DbEngine.MySql, configuration["Connections:MySql"]));
        //        names.AddScoped("PostgreSql", _ => new DbFactory(DbEngine.PostgreSql, configuration["Connections:PostgreSql"]));
        //        //names.AddScoped("MicrosoftSql", _ => new DbFactory(DbEngine.MicrosoftSql, configuration["Connections:MicrosoftSql"]));
        //    });
        //    services.AddScoped<ICategoryRepository, CategoryRepository>();

        //    return services;
        //}
    }

}
