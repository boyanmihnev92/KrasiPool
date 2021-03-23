using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using KrasiPool.Data.Common.Models;

namespace KrasiPool.Data.Models
{
    public class Visit : BaseDeletableModel<int>
    {
        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public int StatusId { get; set; }

        public Status Status { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public DateTime PlannedDate { get; set; }

        public ICollection<Service> Services { get; set; } = new HashSet<Service>();
    }
}
