using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class ProductCustomAttribute
    {
        #region Properties
        public int Id { get; set; }
        public string AttributeValue { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        #endregion Properties

        #region Navigation properties
        public int AttributeId { get; set; }
        public virtual CustomAttribute Attribute { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        #endregion Navigation properties
    }
}
