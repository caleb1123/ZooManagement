using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class AnimalCage
    {
        public int Id { get; set; }
        public int? IdAnimal { get; set; }
        public int? IdCage { get; set; }

        public virtual Animal? IdAnimalNavigation { get; set; }
        public virtual Cage? IdCageNavigation { get; set; }
    }
}
