using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class UserDto
    {
        #region Properties
        public int? Id { get; set; }
        public string? UserName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? ConfirmPassword { get; set; } = string.Empty;
        public string? Role { get; set; }
        public List<string>? Roles { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDelete { get; set; } = false;
        #endregion Properties

        #region Navigation properties
        public int? PictureId { get; set; }
        public Picture? Picture { get; set; }
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        #endregion Navigation properties

    }
}
