using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Picture
    {
        #region Properties
        public int Id { get; set; }
        public string Url { get; set; }
        #endregion Properties

        #region Navigation properties
        public ICollection<ShopStand> ShopStands { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Seller> Sellers { get; set; }
        #endregion Navigation properties
    }
}
