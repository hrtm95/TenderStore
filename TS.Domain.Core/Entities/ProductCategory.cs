using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class ProductCategory
    {
        #region Properties
        public int Id { get; set; }
        #endregion Properties

        #region Navigation properties
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        #region Properties
    }
}
