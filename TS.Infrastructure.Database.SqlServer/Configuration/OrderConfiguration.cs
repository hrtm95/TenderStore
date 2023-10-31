using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.User)
                .WithMany(e => e.Order)
                .HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Status)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.StatusId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Order");
        }
    }
}
