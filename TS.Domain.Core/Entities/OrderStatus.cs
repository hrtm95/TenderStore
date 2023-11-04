using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class OrderStatus
    {
        #region Properties
        public int Id { get; set; }
        public string? Title { get; set; }
        #endregion Properties

        #region Navigation properties
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        #endregion Navigation properties
    }
}
