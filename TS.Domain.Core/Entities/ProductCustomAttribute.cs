﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain.Core.Entities
{
    public class ProductCustomAttribute
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int AttributeId { get; set; }

        public string AttributeValue { get; set; } 

        public virtual CustomAttribute Attribute { get; set; } 

        public virtual Product Product { get; set; } 
    }
}
