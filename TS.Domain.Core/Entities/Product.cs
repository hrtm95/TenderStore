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
        

        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        public ICollection<FixedPrice> FixedPrice { get; set; }

        public ICollection<Category> Categories { get; set; }

        public ICollection<AuctionPrice> AuctionPrice { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<SoldGoods> SoldGoods { get; set; }
    }
}
