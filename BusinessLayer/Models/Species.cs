using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Species
    {
        public Species()
        {
            Animals = new HashSet<Animal>();
        }

        public int IdSpecies { get; set; }
        public string? SpeciesName { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
