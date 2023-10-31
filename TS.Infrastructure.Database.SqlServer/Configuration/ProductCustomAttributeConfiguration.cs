using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace Mp.Infrastructures.Database.SqlServer.EntityConfig
{
    public class ProductCustomAttributeConfiguration : IEntityTypeConfiguration<ProductCustomAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductCustomAttribute> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.productCustomAttributes)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("ProductCustomAttribute");
        }
    }
}
