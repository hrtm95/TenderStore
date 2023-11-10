using Microsoft.EntityFrameworkCore;
using TS.Domain.Core.Entities;
using TS.Infrastructure.Database.SqlServer.Configuration;

namespace TS.Infrastructure.Database.SqlServer.Common
{
    public class TSDbcontext : DbContext
    {
        public TSDbcontext(DbContextOptions<TSDbcontext> options) : base(options)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AuctionPrice> AuctionPrices { get; set; }
        public DbSet<AuctionInformation> AuctionInformations { get; set; }
        public DbSet<ShopStand> ShopStands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<FixedPrice> FixedPrices { get; set; }
        public DbSet<Medal> Medals { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SoldGoods> SoldGoods { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CustomAttribute> CustomAttributes { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCustomAttribute> ProductCustomAttributes { get; set; }
        public DbSet<ProductInventory> ProductInventory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuctionInformationConfiguration).Assembly);
        }
    }
}
