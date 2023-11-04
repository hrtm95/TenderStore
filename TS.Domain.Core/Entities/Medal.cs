using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class Medal
    {
        #region Properties
        public int Id { get; set; }
        public double FeePercentage { get; set; }
        public int ProductCount { get; set; }
        #endregion Properties

        #region Navigation properties
        public ICollection<Seller> Seller { get; set; }
        #endregion Navigation properties

    }
}
