using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ShebaNumber { get; set; }
        public string? CardNumber { get; set; }
        public string? ProfileImgUrl { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime Birthday { get; set; }

        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<SoldGoods> SoldGoods { get; set; }
        public ICollection<AuctionInformation> AuctionInformation { get; set; }
        public ICollection<Order> Order { get; set; }
        public ICollection<FixedPrice> FixedPrice { get; set; }
    }
}
