using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Order)
                 .WithMany(e => e.OrderLines)
                 .HasForeignKey(e => e.OrderId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.OreLines)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("OrderLine");
        }
    }
}
