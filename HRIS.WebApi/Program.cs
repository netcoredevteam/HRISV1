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
using HRIS.WebApi.Mappings;
using HRIS.Service.Objects;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    var services = builder.Services;
    ConfigurationManager configuration = builder.Configuration;

    services.AddControllers()
        .AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase);

    services.AddAutoMapper(typeof(MappingProfile), typeof(ControllerMappingProfile));

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
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });
        c.AddSecurityRequirement(new OpenApiSecurityRequirement()
        {
            {
                new OpenApiSecurityScheme
                {
                Reference = new OpenApiReference
                  {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                  },
                  Scheme = "oauth2",
                  Name = "Bearer",
                  In = ParameterLocation.Header
                },
                new List<string>()
            }
        });
    });

    services.AddCors();

    services.AddHttpClient();

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

    services.AddDistributedSqlServerCache(options =>
    {
        options.ConnectionString = builder.Configuration.GetConnectionString("DistCacheConnection");
        options.SchemaName = "dbo";
        options.TableName = "json_web_tokens";
    });

    services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    services.AddScoped(typeof(IDistributedCacheRepository<>), typeof(DistributedCacheRepository<>));

    // Strongly Typed Objects
    services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

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
}

app.Run();

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
    services.AddScoped<IUserService, UserService>();
    services.AddScoped<IJwtService, JwtService>();
    services.AddScoped<IDailyRecordService, DailyRecordService>();
    services.AddScoped<IEmployeeEmployeeMandatoryService, EmployeeEmployeeMandatoryService>();
    services.AddScoped<IMandatoryService, MandatoryService>();
    services.AddScoped<IWhitelistService, WhitelistService>();
    services.AddScoped<IWorkPositionService, WorkPositionService>();
    services.AddScoped<IScheduleService, ScheduleService>();
    services.AddScoped<IProfileService, ProfileService>();
}