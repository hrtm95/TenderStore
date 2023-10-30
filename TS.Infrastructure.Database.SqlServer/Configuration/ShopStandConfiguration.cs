using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class ShopStandConfiguration : IEntityTypeConfiguration<ShopStand>
    {
        public void Configure(EntityTypeBuilder<ShopStand> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Booth");
        }
    }
}
