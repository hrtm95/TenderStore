using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class AuctionInformation
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public int AuctionId { get; set; }
        public Auction Auction { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
