using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KrasiPool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KrasiPool.Data.Configurations
{
    public class CustomerRequestConfiguration : IEntityTypeConfiguration<CustomerRequest>
    {
        public void Configure(EntityTypeBuilder<CustomerRequest> custReq)
        {
            custReq
                .HasOne(v => v.Customer)
                .WithMany(v => v.CustomerRequests)
                .HasForeignKey(v => v.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            custReq
                .HasOne(v => v.ServiceType)
                .WithMany(v => v.CustomerRequests)
                .HasForeignKey(v => v.ServiceTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
