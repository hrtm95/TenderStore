using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class FixedPriceConfiguration : IEntityTypeConfiguration<FixedPrice>
    {
        public void Configure(EntityTypeBuilder<FixedPrice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.FixedPrice)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("FixedPrice");
        }
    }
}
