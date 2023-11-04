using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;
using TS.Domain.Core.Enums;

namespace TS.Domain.Core.Dtos
{
    public class ProductDto
    {
        #region Properties
        public int Id { get; set; }
        private SellingTypeEnum sellingType { get; set; }
        public int Status { get; set; }
        #endregion Properties

        #region Navigation properties
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        #endregion Navigation properties

    }
}
