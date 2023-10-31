using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.ProductCategories)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Category)
                .WithMany(e => e.ProductCategories)
                .HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("ProductCategory");
        }
    }
}
