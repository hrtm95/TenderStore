using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Medal)
               .WithMany(e => e.Seller)
               .HasForeignKey(e => e.MedalId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Picture)
             .WithMany(e => e.Sellers)
             .HasForeignKey(e => e.PictureId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Address)
             .WithMany(e => e.Sellers)
             .HasForeignKey(e => e.AddressId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("Seller");
        }
    }
}
