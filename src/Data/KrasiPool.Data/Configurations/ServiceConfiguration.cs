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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> service)
        {
            service
                 .HasOne(v => v.ServiceType)
                 .WithMany(v => v.Services)
                 .HasForeignKey(v => v.ServiceTypeId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Restrict);

            service
                .HasOne(v => v.Visit)
                .WithMany(v => v.Services)
                .HasForeignKey(v => v.VisitId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            service
                .HasOne(v => v.Status)
                .WithMany(v => v.Services)
                .HasForeignKey(v => v.StatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            service
                .HasOne(v => v.Survey)
                .WithMany(v => v.Services)
                .HasForeignKey(v => v.SurveyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            service
                .HasOne(v => v.User)
                .WithMany(v => v.Services)
                .HasForeignKey(v => v.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
