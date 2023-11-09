using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Cage
    {
        public Cage()
        {
            AnimalCages = new HashSet<AnimalCage>();
            CageAreas = new HashSet<CageArea>();
        }

        public int IdCage { get; set; }
        public string? CageName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<AnimalCage> AnimalCages { get; set; }
        public virtual ICollection<CageArea> CageAreas { get; set; }
    }
}
