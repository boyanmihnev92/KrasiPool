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
    public class CustomerAssignmentConfiguration : IEntityTypeConfiguration<CustomerAssignment>
    {
        public void Configure(EntityTypeBuilder<CustomerAssignment> custAssign)
        {
            custAssign
                 .HasOne(v => v.Territory)
                 .WithMany(v => v.Assignments)
                 .HasForeignKey(v => v.PolygonId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);

            custAssign
                .HasOne(v => v.Customer)
                .WithMany(v => v.Assignments)
                .HasForeignKey(v => v.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
