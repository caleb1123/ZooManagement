using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Animal
    {
        public Animal()
        {
            AnimalCages = new HashSet<AnimalCage>();
            Experiences = new HashSet<Experience>();
        }

        public int IdAnimal { get; set; }
        public string AnimalName { get; set; } = null!;
        public string? Nickname { get; set; }
        public int? IdSpecies { get; set; }
        public int? IdDiet { get; set; }
        public string? Description { get; set; }
        public string? Size { get; set; }
        public string? Weight { get; set; }

        public virtual Diet? IdDietNavigation { get; set; }
        public virtual Species? IdSpeciesNavigation { get; set; }
        public virtual ICollection<AnimalCage> AnimalCages { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
    }
}
