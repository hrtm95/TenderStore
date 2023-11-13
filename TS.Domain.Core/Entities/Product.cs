using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Enums;

namespace TS.Domain.Core.Entities
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public SellingTypeEnum SellingType { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        #endregion Properties

        #region Navigation properties
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        public ICollection<FixedPrice> FixedPrice { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<AuctionPrice> AuctionPrices { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<SoldGoods> SoldGoods { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderLine> OreLines { get; set; }
        public ICollection<ProductCustomAttribute> productCustomAttributes { get; set; }
        public ICollection<ProductInventory> productInventories { get; set; }
        #endregion Navigation properties
    }
}
