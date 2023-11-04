using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class SellerDto
    {
        #region Properties
        public int Id { get; set; }
        public string SellerName { get; set; }
        #endregion Properties

        #region Navigation properties
        public int MedalId { get; set; }
        public Medal Medal { get; set; }
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        #endregion Navigation properties
    }
}
