using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class CustomAttributeDto
    {
        #region Properties
        public int Id { get; set; }
        public string AttributeTitle { get; set; }
        public bool IsDeleted { get; set; }
        #endregion Properties

        #region Navigation properties
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } 
        #endregion Navigation properties
    }
}
