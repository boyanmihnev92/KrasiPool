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
    public class ServicePriceConfiguration : IEntityTypeConfiguration<ServicePrice>
    {
        public void Configure(EntityTypeBuilder<ServicePrice> price)
        {
            price
                .HasOne(v => v.ServiceType)
                .WithMany(v => v.Prices)
                .HasForeignKey(v => v.ServiceTypeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
