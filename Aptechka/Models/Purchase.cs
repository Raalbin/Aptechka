using System;
using System.Collections.Generic;

namespace Aptechka.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public int? IdDrugs { get; set; }
        public int? IdRequests { get; set; }
        public int? Count { get; set; }

        public virtual Drug? IdDrugsNavigation { get; set; }
        public virtual Request? IdRequestsNavigation { get; set; }
    }
}
