using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Entities;

namespace TS.Domain.Core.Dtos
{
    public class ShopStandDto
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion Properties

        #region Navigation properties
        public int sellerId { get; set; }
        public Seller? seller { get; set; }
        public int PictureId { get; set; }
        public Picture? Picture { get; set; }
        #endregion Navigation properties
    }
}
