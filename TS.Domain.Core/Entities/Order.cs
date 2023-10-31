using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int StatusId { get; set; }

        public DateTime OrderAt { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public virtual OrderStatus Status { get; set; } 
        public ICollection<ProductInventory> productInventories { get; set; }

    }
}
