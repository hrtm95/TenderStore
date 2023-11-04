using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class OrderDto
    {
        #region Properties
        public int Id { get; set; }
        public DateTime OrderAt { get; set; }
        #endregion Properties

        #region Navigation properties
        public int UserId { get; set; }
        public User User { get; set; }
        public int StatusId { get; set; }
        public OrderStatus Status { get; set; }
        #endregion Navigation properties
    }
}
