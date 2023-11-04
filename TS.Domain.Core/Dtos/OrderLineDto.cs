using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class OrderLineDto
    {
        #region Properties
        public int Id { get; set; }
        public int Qty { get; set; }
        public int ProductPrice { get; set; }
        #endregion Properties

        #region Navigation properties
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        #endregion Navigation properties
    }
}
