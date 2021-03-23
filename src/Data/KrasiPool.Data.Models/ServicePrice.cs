using System;
using System.Collections.Generic;
using System.Text;

namespace KrasiPool.Data.Models
{
    public class ServicePrice
    {
        public int Id { get; set; }

        public int ServiceTypeId { get; set; }

        public ServiceType ServiceType { get; set; }

        public decimal Price { get; set; }
    }
}
