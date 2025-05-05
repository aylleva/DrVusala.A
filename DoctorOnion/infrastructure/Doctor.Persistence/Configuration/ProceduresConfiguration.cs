using Doctor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doctor.Persistence.Configuration
{
    internal class ProceduresConfiguration : IEntityTypeConfiguration<Procedures>
    {
        public void Configure(EntityTypeBuilder<Procedures> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(200)");
         
        }
    }
}
