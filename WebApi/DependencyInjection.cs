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
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            return services;
        }
    }

}
