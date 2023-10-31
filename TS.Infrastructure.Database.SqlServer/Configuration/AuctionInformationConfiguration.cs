using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class AuctionInformationConfiguration : IEntityTypeConfiguration<AuctionInformation>
    {
        public void Configure(EntityTypeBuilder<AuctionInformation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.AuctionPrice)
                .WithMany(e => e.AuctionInformation)
                .HasForeignKey(e => e.AuctionPriceId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User)
                .WithMany(e => e.AuctionInformation)
                .HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("AuctionInformation");
        }
    }
}
