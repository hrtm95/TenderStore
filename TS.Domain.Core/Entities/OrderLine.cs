using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class OrderLine
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Qty { get; set; }

        public int ProductPriceId { get; set; }

        public  Order Order { get; set; } 

        public  Product Product { get; set; } 
    }
}
