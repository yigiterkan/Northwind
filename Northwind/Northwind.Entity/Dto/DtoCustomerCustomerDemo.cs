﻿using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoCustomerCustomerDemo : DtoBase
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        //public virtual Customer Customer { get; set; }
        //public virtual CustomerDemographic CustomerType { get; set; }
    }
}
