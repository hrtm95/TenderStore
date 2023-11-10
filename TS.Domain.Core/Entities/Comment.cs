using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Comment
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        #endregion Properties

        #region Navigation properties
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        #endregion Navigation properties
    }
}
