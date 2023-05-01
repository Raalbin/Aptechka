using System;
using System.Collections.Generic;

namespace Aptechka.Models
{
    public partial class Request
    {
        public Request()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public DateTime? DateIn { get; set; }
        public int? DrugstoreId { get; set; }
        public DateTime? DateFinish { get; set; }
        public int? StatusId { get; set; }

        public virtual Drugstore? Drugstore { get; set; }
        public virtual Status? Status { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
