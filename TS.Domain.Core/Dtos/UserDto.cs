using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class UserDto
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        #endregion Properties

        #region Navigation properties
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        #endregion Navigation properties

    }
}
