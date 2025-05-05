using Doctor.Application.Interfaces.Services;
using Doctor.Persistence.DAL;
using Doctor.Persistence.Implementations.Services;
using DoctorMVC.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DoctorMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();


            builder.Services.AddHttpClient("DoctorAPI", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7168/api/"); // API'nin Base URL'si
            });

            builder.Services.AddDbContext<AppDbContext>(opt =>
          opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
          );

            builder.Services.AddScoped<ProceduresApiService>();
            builder.Services.AddScoped<SlidesGetApiService>();
            builder.Services.AddScoped<ILayoutService, LayoutService>();
            builder.Services.AddHttpContextAccessor();


            var app = builder.Build();


            app.UseStaticFiles();
            app.MapControllerRoute("default",
                "{controller=home}/{action=index}/{id?}"
                );

            app.Run();
        }
    }
}
