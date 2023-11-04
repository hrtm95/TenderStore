using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class FixedPriceDto
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
