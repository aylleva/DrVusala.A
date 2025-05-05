
using Doctor.Application.Interfaces.Repositories;
using Doctor.Application.Interfaces.Services;
using Doctor.Domain.Entities;
using Doctor.Persistence.DAL;
using Doctor.Persistence.Implementations.Repositories;
using Doctor.Persistence.Implementations.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Doctor.Persistence.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection service, IConfiguration configuration)
        {

            service.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("Default"))
            );

            service.AddScoped<ISlideRepository, SlideRepository>();
            service.AddScoped<IProceduresRepository, ProceduresRepository>();
            service.AddScoped<ISlidesService, SlideService>();
            service.AddScoped<IProceduresService, ProcedureService>();
       

            return service;
        }
    }
}
