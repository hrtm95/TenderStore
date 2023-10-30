using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class ShopStand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public int sellerId { get; set; } 
        public Seller? seller { get; set; }  

        public ICollection<Product> Products { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
