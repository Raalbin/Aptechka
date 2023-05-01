using System;
using System.Collections.Generic;

namespace Aptechka.Models
{
    public partial class Status
    {
        public Status()
        {
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Code { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
