using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

using KrasiPool.Data.Common.Models;

namespace KrasiPool.Data.Models
{
    public class Customer : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string TelephoneNumber { get; set; }

        [Required]
        public bool HasGarden { get; set; }

        public DateTime? LastVisitDate { get; set; }

        public int PolygonId { get; set; }

        public Polygon Territory { get; set; }

        public virtual ICollection<CustomerRequest> CustomerRequests { get; set; } = new HashSet<CustomerRequest>();

        public virtual ICollection<CustomerAssignment> Assignments { get; set; } = new HashSet<CustomerAssignment>();

        public virtual ICollection<Visit> Visits { get; set; } = new HashSet<Visit>();
    }
}
