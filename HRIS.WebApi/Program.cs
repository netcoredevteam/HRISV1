using HRIS.Repository;
using HRIS.Repository.Interfaces;
using HRIS.Repository.Implementations;
using HRIS.Service.Interfaces;
using HRIS.Service.Mappings;
using HRIS.Service.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Reflection;

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
    services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    services.AddScoped<IUserRepository, UserRepository>();

    // Services
    services.AddScoped<IEmployeeService, EmployeeService>();
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

    app.UseStaticFiles();

    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
