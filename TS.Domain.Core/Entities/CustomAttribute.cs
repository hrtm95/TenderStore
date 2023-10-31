using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class CustomAttribute
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string AttributeTitle { get; set; } 

        public virtual Category Category { get; set; } 

        public virtual ICollection<ProductCustomAttribute> ProductCustomAttributes { get; set; } = new List<ProductCustomAttribute>();

    }
}
