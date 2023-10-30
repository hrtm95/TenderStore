using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        public string SellerName { get; set; }

        public ShopStand? ShopStand { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
