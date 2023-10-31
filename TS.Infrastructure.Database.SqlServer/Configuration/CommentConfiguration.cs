using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(e => e.Product)
                .WithMany(e => e.Comment)
                .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User)
                .WithMany(e => e.Comments)
                .HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("Comment");
        }
    }
}
