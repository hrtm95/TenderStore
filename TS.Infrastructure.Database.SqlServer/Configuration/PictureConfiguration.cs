using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class PictureConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Picture");
        }
    }
}
