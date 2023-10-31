using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class MedalConfiguration : IEntityTypeConfiguration<Medal>
    {
        public void Configure(EntityTypeBuilder<Medal> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Medal");
        }
    }
}
