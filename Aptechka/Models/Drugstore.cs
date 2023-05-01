using System;
using System.Collections.Generic;

namespace Aptechka.Models
{
    public partial class Drugstore
    {
        public Drugstore()
        {
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? AddressId { get; set; }
        public string? Telephone { get; set; }
        public string? PharmacyInn { get; set; }

        public virtual Address? Address { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
