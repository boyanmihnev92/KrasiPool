using System;
using System.Collections.Generic;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class Polygon
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();

        public virtual ICollection<CustomerAssignment> Assignments { get; set; } = new HashSet<CustomerAssignment>();
    }
}
