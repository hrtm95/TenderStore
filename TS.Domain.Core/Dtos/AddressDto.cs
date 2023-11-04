using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class AddressDto
    {
        #region Properties
        public int Id { get; set; }
        public int? CityId { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string MoreDescription { get; set; }
        #endregion Properties

        #region Navigation properties
        public City? City { get; set; }
        #endregion Navigation properties

    }
}
