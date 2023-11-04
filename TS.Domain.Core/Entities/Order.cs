using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Order
    {
        #region Properties
        public int Id { get; set; }
        public DateTime OrderAt { get; set; }
        #endregion Properties

        #region Navigation properties
        public int UserId { get; set; }
        public User User { get; set; }
        public int StatusId { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public ICollection<ProductInventory> productInventories { get; set; }
        #endregion Navigation properties
    }
}
