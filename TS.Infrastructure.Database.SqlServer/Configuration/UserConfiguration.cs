using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Picture)
           .WithMany(e => e.Users)
           .HasForeignKey(e => e.PictureId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Address)
             .WithMany(e => e.Users)
             .HasForeignKey(e => e.AddressId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Users");
        }
    }
}
