using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TS.Domain.Core.Enums
{
    public enum SellingTypeEnum
    {
        [Display(Name = "قیمت مقطوع")]
        FixedPrice = 0,
        [Display(Name = "قیمت مزایده")]
        AuctionPrice = 1,
    }
}
