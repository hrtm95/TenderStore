using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Seller
    {
        #region Properties
        public int Id { get; set; }
        public string SellerName { get; set; }
        #endregion Properties

        #region Navigation properties
        public int MedalId { get; set; }
        public Medal Medal { get; set; }
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public ShopStand shopStands { get; set; }
        public ICollection<Product>? Products { get; set; }
        #endregion Navigation properties
    }
}
