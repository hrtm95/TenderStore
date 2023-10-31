﻿using System;
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

        public int AuctionPriceId { get; set; }
        public AuctionPrice AuctionPrice { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
