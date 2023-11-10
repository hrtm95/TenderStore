using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class ShopStand
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        #endregion Properties

        #region Navigation properties
        public int sellerId { get; set; }
        public Seller? seller { get; set; }
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        public ICollection<Product> Products { get; set; }
        #endregion Navigation properties
    }
}
