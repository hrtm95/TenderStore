using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class AuctionPrice
    {
        public int Id { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsCompleted { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
