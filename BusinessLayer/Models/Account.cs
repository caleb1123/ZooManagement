using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Account
    {
        public Account()
        {
            Experiences = new HashSet<Experience>();
            Tickets = new HashSet<Ticket>();
        }

        public int IdUser { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Name { get; set; }
        public int? IdRole { get; set; }

        public virtual Role? IdRoleNavigation { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
