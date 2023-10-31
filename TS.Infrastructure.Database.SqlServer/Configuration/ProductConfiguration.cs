using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Seller)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.SellerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Picture)
               .WithMany(e => e.Products)
               .HasForeignKey(e => e.PictureId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Product");
        }
    }
}
