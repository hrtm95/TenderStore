using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ShebaNumber { get; set; }
        public string? CardNumber { get; set; }
        public string? ProfileImgUrl { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? UserId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime? Birthday { get; set; }

        public int? AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
