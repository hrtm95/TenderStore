using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class SoldGoodsConfiguration  : IEntityTypeConfiguration<SoldGoods>
    {
        public void Configure(EntityTypeBuilder<SoldGoods> builder)
    {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.SoldGoods)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User)
                .WithMany(e => e.SoldGoods)
                .HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("SoldGoods");
        }
}
}
