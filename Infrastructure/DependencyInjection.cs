using Application.IRepositories.Cms;
using Application.Services.Cms;
using Application.Services.Cms.Interfaces;
using ApplicationCore.Databases.Definitions;
using Domain;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            BaseEntity.Initialize(new DbFactory(DbEngine.PostgreSql, configuration["Connections:PostgreSql"]));

            services.AddNamed<DbFactory>(names =>
            {
                //names.AddScoped("MySql", _ => new DbFactory(DbEngine.MySql, configuration["Connections:MySql"]));
                names.AddScoped("PostgreSql", _ => new DbFactory(DbEngine.PostgreSql, configuration["Connections:PostgreSql"]));
                //names.AddScoped("MicrosoftSql", _ => new DbFactory(DbEngine.MicrosoftSql, configuration["Connections:MicrosoftSql"]));
            });

            #region DI Repositories
            services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));
            services.AddScoped(typeof(IClothingRepository), typeof(ClothingRepository));
            services.AddScoped(typeof(IClothingMediaCollectionRepository), typeof(ClothingMediaCollectionRepository));

            #endregion

            #region DI Services

            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(IClothingService), typeof(ClothingService));
            services.AddScoped(typeof(IClothingMediaCollectionService), typeof(ClothingMediaCollectionService));

            #endregion
            return services;
        }
    }

}
