using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class ProductCustomAttributeDto
    {
        #region Properties
        public int Id { get; set; }
        public string AttributeValue { get; set; }
        #endregion Properties

        #region Navigation properties
        public int AttributeId { get; set; }
        public virtual CustomAttribute Attribute { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        #endregion Navigation properties
    }
}
