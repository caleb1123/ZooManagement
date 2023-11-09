using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class ZooArea
    {
        public ZooArea()
        {
            CageAreas = new HashSet<CageArea>();
        }

        public int IdArea { get; set; }
        public string AreaName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<CageArea> CageAreas { get; set; }
    }
}
