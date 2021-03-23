using KrasiPool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KrasiPool.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> customer)
        {
            customer
                .HasOne(v => v.Territory)
                .WithMany(v => v.Customers)
                .HasForeignKey(v => v.PolygonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
