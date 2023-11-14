using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Address
    {
        #region Properties
        public int Id { get; set; }
        public int? CityId { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string MoreDescription { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        #endregion Properties

        #region Navigation properties
        public ICollection<Customer> Customers { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Seller> Sellers { get; set; }
        public City? City { get; set; }
        #endregion Navigation properties

    }
}
