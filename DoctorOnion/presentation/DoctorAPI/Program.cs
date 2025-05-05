using Doctor.Application.ServiceRegistration;
using Doctor.Domain.Entities;
using Doctor.Persistence.DAL;
using Doctor.Persistence.ServiceRegistration;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;

namespace DoctorAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1",
                    License = new OpenApiLicense
                    {
                        Name = "MIT LICENSE",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });
            });

            builder.Services.AddPersistenceServices(builder.Configuration).AddApplicationServices();

            builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opt.Lockout.MaxFailedAccessAttempts = 3;

                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;

                opt.User.RequireUniqueEmail = false;
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", builder =>
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader());
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
        }
    }
}
