using System;
using System.Collections.Generic;

namespace AptechkaWPF
{

    public partial class Address
    {
        public int Id { get; set; }

        public string? City { get; set; }

        public string? Street { get; set; }

        public string? Home { get; set; }

        public virtual ICollection<Drugstore> Drugstores { get; set; } = new List<Drugstore>();

        public virtual ICollection<Producer> Producers { get; set; } = new List<Producer>();
    }

}