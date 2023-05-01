using System;
using System.Collections.Generic;

namespace Aptechka.Models
{
    public partial class Address
    {
        public Address()
        {
            Drugstores = new HashSet<Drugstore>();
            Producers = new HashSet<Producer>();
        }

        public int Id { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? Home { get; set; }

        public virtual ICollection<Drugstore> Drugstores { get; set; }
        public virtual ICollection<Producer> Producers { get; set; }
    }
}
