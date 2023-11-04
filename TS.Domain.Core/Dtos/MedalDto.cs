using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Dtos
{
    public class MedalDto
    {
        #region Properties
        public int Id { get; set; }
        public double FeePercentage { get; set; }
        public int ProductCount { get; set; }
        #endregion Properties

    }
}
