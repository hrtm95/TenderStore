using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class AuctionPriceConfiguration : IEntityTypeConfiguration<AuctionPrice>
    {
        public void Configure(EntityTypeBuilder<AuctionPrice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.AuctionPrices)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("AuctionPrice");
        }
    }
}
