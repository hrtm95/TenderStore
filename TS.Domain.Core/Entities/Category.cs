using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Category
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion Properties

        #region Navigation properties
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<CustomAttribute> CustomAttributes { get; set; }
        #endregion Navigation properties
    }
}
