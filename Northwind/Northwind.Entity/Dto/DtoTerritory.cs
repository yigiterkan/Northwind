using Northwind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoTerritory : DtoBase
    {
        public DtoTerritory()
        {
           // EmployeeTerritories = new HashSet<EmployeeTerritory>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        //public virtual Region Region { get; set; }
        //public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
