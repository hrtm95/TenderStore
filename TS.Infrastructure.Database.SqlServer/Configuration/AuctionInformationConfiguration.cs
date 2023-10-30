using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class AuctionInformationConfiguration : IEntityTypeConfiguration<AuctionInformation>
    {
        public void Configure(EntityTypeBuilder<AuctionInformation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("AuctionInformation");
        }
    }
}
