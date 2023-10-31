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
        public int Id { get; set; }
        private SellingTypeEnum sellingType { get; set; }


        public int Status { get; set; }

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
    }
}
