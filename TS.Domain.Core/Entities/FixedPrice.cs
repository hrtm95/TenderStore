using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class FixedPrice
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
