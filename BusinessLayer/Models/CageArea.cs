using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class CageArea
    {
        public int Id { get; set; }
        public int? IdCage { get; set; }
        public int? IdArea { get; set; }

        public virtual ZooArea? IdAreaNavigation { get; set; }
        public virtual Cage? IdCageNavigation { get; set; }
    }
}
