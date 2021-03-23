using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KrasiPool.Data.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; } = new HashSet<Service>();

        public virtual ICollection<Visit> Visits { get; set; } = new HashSet<Visit>();
    }
}
