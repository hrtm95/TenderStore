using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class FixedPrice
    {
        #region Properties
        public int Id { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        #endregion Properties

        #region Navigation properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
        #endregion Navigation properties
    }
}
