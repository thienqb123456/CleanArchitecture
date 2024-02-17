using Application.IRepositories;
using Application.Services;
using Application.Services.Interfaces;
using ApplicationCore.Commons.NamedServices;
using ApplicationCore.Databases;
using ApplicationCore.Databases.Definitions;
using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

BaseEntity.Initialize(new DbFactory(DbEngine.PostgreSql, configuration["Connections:PostgreSql"]));

builder.Services.AddSingleton(typeof(IMemoryCache), typeof(MemoryCache));

builder.Services.AddNamed<DbFactory>(names =>
{
    //names.AddScoped("MySql", _ => new DbFactory(DbEngine.MySql, configuration["Connections:MySql"]));
    names.AddScoped("PostgreSql", _ => new DbFactory(DbEngine.PostgreSql, configuration["Connections:PostgreSql"]));
    //names.AddScoped("MicrosoftSql", _ => new DbFactory(DbEngine.MicrosoftSql, configuration["Connections:MicrosoftSql"]));
});


builder.Services.AddScoped(typeof(ICategoryRepository), typeof(CategoryRepository));

builder.Services.AddScoped(typeof(ICategoryService), typeof(CategoryService));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
