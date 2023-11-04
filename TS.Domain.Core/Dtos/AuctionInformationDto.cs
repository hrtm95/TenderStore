using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class AuctionInformationDto
    {
        #region Properties
        public int Id { get; set; }
        public double Price { get; set; }
        #endregion Properties

        #region Navigation properties
        public int AuctionPriceId { get; set; }
        public AuctionPrice AuctionPrice { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        #endregion Navigation properties
    }
}
