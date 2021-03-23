using System;
using System.Collections.Generic;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class CustomerRequest
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int ServiceTypeId { get; set; }

        public ServiceType ServiceType { get; set; }

        public DateTime? RequestedDate { get; set; }
    }
}
