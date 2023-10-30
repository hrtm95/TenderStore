using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Picture
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int ShopStandId { get; set; }
        public ShopStand ShopStand { get; set; }
    }
}
