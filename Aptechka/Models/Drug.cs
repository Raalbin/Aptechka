using System;
using System.Collections.Generic;

namespace Aptechka.Models
{
    public partial class Drug
    {
        public Drug()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? ProducerId { get; set; }
        public DateTime? DateOfManufacture { get; set; }
        public DateTime? BestBeforeDate { get; set; }

        public virtual Producer? Producer { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
