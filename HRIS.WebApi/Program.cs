global using System;
global using System.Linq;
global using System.Threading.Tasks;
global using System.Collections.Generic;
global using System.Collections.ObjectModel;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Filters;
global using HRIS.Domain.Entities;
global using HRIS.Repository.Implementations;
global using HRIS.Repository.Interfaces;
global using HRIS.Service.DTOs;
global using HRIS.Service.Interfaces;
global using HRIS.Utility.Constants;
global using HRIS.WebApi.Attributes;
global using HRIS.WebApi.Models.RequestModels.Authenticated.Employee;
global using HRIS.WebApi.Models.Request;

using System.Reflection;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using HRIS.Repository;
using HRIS.Service.Mappings;
using HRIS.Service.Implementations;
using HRIS.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    var services = builder.Services;
    ConfigurationManager configuration = builder.Configuration;

    services.AddControllers();
    services.AddAutoMapper(typeof(MappingProfile));

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();

    services.AddSwaggerGen(c =>
    {
        c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "HRIS",
        });
    });

    services.AddCors();

    services.AddApiVersioning(config =>
    {
        // Specify the default API Version as 1.0
        config.DefaultApiVersion = new ApiVersion(1, 0);
        // If the client hasn't specified the API version in the request, use the default API version number 
        config.AssumeDefaultVersionWhenUnspecified = true;
        // Advertise the API versions supported for the particular endpoint
        config.ReportApiVersions = true;
    });

    services.AddDbContext<ApplicationDbContext>(options =>
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        options.UseSqlServer(connectionString);
    });

    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

    // Repository
    MapRepositories(services);

    // Services
    MapServices(services);
}

var app = builder.Build();

{
    using (var scope = app.Services.CreateScope())
    {
        var dataContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        dataContext.Database.Migrate();
    }

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();

        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "HRIS.WebAPI");
            c.RoutePrefix = "swagger";
        });
    }

    //app.UseStaticFiles();

    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.UseHttpsRedirection();

    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();

    app.Run();
}


void MapRepositories(IServiceCollection services)
{
    services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    services.AddScoped<IUserRepository, UserRepository>();
    services.AddScoped<ICalendarTaskRepository, CalendarTaskRepository>();
    services.AddScoped<IWhitelistRepository, WhitelistRepository>();
    services.AddScoped<IScheduleRepository, ScheduleRepository>();
    services.AddScoped<ILeaveRecordRepository, LeaveRecordRepository>();
    services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
    services.AddScoped<IDailyRecordRepository, DailyRecordRepository>();
    services.AddScoped<IMandatoryRepository, MandatoryRepository>();
    services.AddScoped<IWorkPositionRepository, WorkPositionRepository>();
}

void MapServices(IServiceCollection services)
{
    services.AddScoped<IEmployeeService, EmployeeService>();
    services.AddScoped<IJwtService, JwtService>();
    services.AddScoped<IEmployeeEmployeeMandatoryService, EmployeeEmployeeMandatoryService>();
}