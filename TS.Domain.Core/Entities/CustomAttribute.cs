using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class CustomAttribute
    {
        #region Properties
        public int Id { get; set; }
        public string AttributeTitle { get; set; }
        public bool IsDeleted { get; set; }
        #endregion Properties

        #region Navigation properties
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } 
        public virtual ICollection<ProductCustomAttribute> ProductCustomAttributes { get; set; } = new List<ProductCustomAttribute>();
        #endregion Navigation properties
    }
}
