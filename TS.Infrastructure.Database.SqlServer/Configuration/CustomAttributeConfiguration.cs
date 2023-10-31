using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class CustomAttributeConfiguration : IEntityTypeConfiguration<CustomAttribute>
    {
        public void Configure(EntityTypeBuilder<CustomAttribute> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Category)
                .WithMany(e => e.CustomAttributes)
                .HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("CustomAttribute");
        }
    }
}
