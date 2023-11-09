using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Food
    {
        public Food()
        {
            Diets = new HashSet<Diet>();
        }

        public int IdFood { get; set; }
        public string FoodName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Diet> Diets { get; set; }
    }
}
