using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;

namespace TS.Infrastructure.Database.SqlServer.Common
{
    public class TSDbcontext : DbContext
    {
        public TSDbcontext(DbContextOptions<TSDbcontext> options) : base(options)
        {

        }
        public DbSet<AuctionPrice> AuctionPrice { get; set; }
        public DbSet<AuctionInformation> AuctionInformations { get; set; }
        public DbSet<ShopStand> ShopStand { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FixedPrice> FixedPrices { get; set; }
        public DbSet<Medal> Medals { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SoldGoods> SoldGoods { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
