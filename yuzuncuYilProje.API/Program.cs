using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AutoMapper;
using yuzuncuYilProje.Core.Repositories;
using yuzuncuYilProje.Core.Services;
using yuzuncuYilProje.Core.UnitOfWorks;
using yuzuncuYilProje.Repository;
using yuzuncuYilProje.Repository.Repositories;
using yuzuncuYilProje.Repository.UnitOfWorks;
using yuzuncuYilProje.Service;
using yuzuncuYilProje.Service.Mapping;
using yuzuncuYilProje.Service.Services;
using yuzuncuYilProje.Service.Validations;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddControllers()
    .AddFluentValidation(x =>
    {
        x.RegisterValidatorsFromAssemblyContaining<TeamDtoValidator>();
        x.RegisterValidatorsFromAssemblyContaining<UserDtoValidator>();
        x.RegisterValidatorsFromAssemblyContaining<UserProfileDtoValidator>();
    });

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

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
