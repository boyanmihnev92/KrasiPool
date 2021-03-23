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
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> visit)
        {
            visit
                .HasOne(v => v.Customer)
                .WithMany(v => v.Visits)
                .HasForeignKey(v => v.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            visit
                .HasOne(v => v.Status)
                .WithMany(v => v.Visits)
                .HasForeignKey(v => v.StatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            visit
                .HasOne(v => v.User)
                .WithMany(v => v.Visits)
                .HasForeignKey(v => v.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
