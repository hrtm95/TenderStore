using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string MoreDescription { get; set; }
        
        public ICollection<User> Users { get; set; }
        public ICollection<Seller> Sellers { get; set; }
    }
}
