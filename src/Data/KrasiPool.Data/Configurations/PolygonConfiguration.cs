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
    public class PolygonConfiguration : IEntityTypeConfiguration<Polygon>
    {
        public void Configure(EntityTypeBuilder<Polygon> polygon)
        {
            polygon
                .HasOne(v => v.User)
                .WithMany(v => v.Territories)
                .HasForeignKey(v => v.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
