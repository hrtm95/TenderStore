using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Medal
    {
        public int Id { get; set; }
        public double FeePercentage { get; set; }
        public int ProductCount { get; set; }
        public ICollection<Seller> Seller { get; set; }

    }
}
