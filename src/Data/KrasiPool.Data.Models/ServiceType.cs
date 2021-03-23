using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public bool RequiresCleaningProduct { get; set; }

        public virtual ICollection<CustomerRequest> CustomerRequests { get; set; } = new HashSet<CustomerRequest>();

        public virtual ICollection<Service> Services { get; set; } = new HashSet<Service>();

        public virtual ICollection<ServicePrice> Prices { get; set; } = new HashSet<ServicePrice>();
    }
}
