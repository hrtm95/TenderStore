using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class ProductCategoryDto
    {
        #region Properties
        public int Id { get; set; }
        #endregion Properties

        #region Navigation properties
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        #endregion Navigation properties
    }
}
