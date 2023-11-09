using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Diet
    {
        public Diet()
        {
            Animals = new HashSet<Animal>();
        }

        public int IdDiet { get; set; }
        public int? IdFood { get; set; }
        public string? FoodFrequecy { get; set; }
        public int? FoodQuantity { get; set; }

        public virtual Food? IdFoodNavigation { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
