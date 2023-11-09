using System;
using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public partial class Ticket
    {
        public int IdTicket { get; set; }
        public int? IdUser { get; set; }
        public int? QuantityChild { get; set; }
        public int? QuantityAdult { get; set; }
        public DateTime? Date { get; set; }

        public virtual Account? IdUserNavigation { get; set; }
    }
}
