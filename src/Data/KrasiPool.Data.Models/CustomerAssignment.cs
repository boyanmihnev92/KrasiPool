using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class CustomerAssignment
    {
        public int Id { get; set; }

        public int PolygonId { get; set; }

        public Polygon Territory { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }
    }
}
