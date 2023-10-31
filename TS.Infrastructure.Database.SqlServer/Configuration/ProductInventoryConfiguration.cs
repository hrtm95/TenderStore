using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class ProductInventoryConfiguration : IEntityTypeConfiguration<ProductInventory>
    {
        public void Configure(EntityTypeBuilder<ProductInventory> builder)
        {

            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.productInventories)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Order)
               .WithMany(e => e.productInventories)
               .HasForeignKey(e => e.OrderId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("ProductInventory");
        }
    }
}
