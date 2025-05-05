
using Doctor.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Doctor.Persistence.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Slides> Slides { get; set; }
        public DbSet<ContactDatas> ContactDatas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            RegisterDbSets(builder);
            base.OnModelCreating(builder);
        }

        private void RegisterDbSets(ModelBuilder modelBuilder)
        {
            var entities = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.Namespace == "Doctor.Domain.Entities");

            foreach (var entity in entities)
            {
                modelBuilder.Entity(entity);
            }
        }
    }
}
