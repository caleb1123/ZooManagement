using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Experience
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public DateTime? StartDate { get; set; }
        public int? IdAnimal { get; set; }

        public virtual Animal? IdAnimalNavigation { get; set; }
        public virtual Account? IdUserNavigation { get; set; }
    }
}
