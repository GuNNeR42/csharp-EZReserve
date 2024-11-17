using csharp_EZReserve.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharp_EZReserve.Models.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");

            builder.HasKey(c => c.CustomerId);

            builder.Property(c => c.CustomerId)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName)
                .HasColumnName("first_name")
                .IsRequired();

            builder.Property(c => c.LastName)
                .HasColumnName("last_name")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnName("email");

            builder.Property(c => c.StreetAddress)
                .HasColumnName("street_address");

            builder.Property(c => c.City)
                .HasColumnName("city");

            builder.Property(c => c.PostalCode)
                .HasColumnName("postal_code");

            builder.HasMany(c => c.Reservations)
                   .WithOne(r => r.Customer)
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
