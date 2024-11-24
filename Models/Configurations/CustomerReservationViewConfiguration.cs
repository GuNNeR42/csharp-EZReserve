using csharp_EZReserve.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharp_EZReserve.Models.Configurations
{
    public class CustomerReservationViewConfiguration : IEntityTypeConfiguration<CustomerReservationView>
    {
        public void Configure(EntityTypeBuilder<CustomerReservationView> builder)
        {
            builder.HasNoKey(); // Views don't have a primary key
            builder.ToView("customer_reservation_view"); // Map to the view name in the database

            builder.Property(x => x.CustomerId)
                .HasColumnName("customer_id");

            builder.Property(x => x.FirstName)
                .HasColumnName("first_name");

            builder.Property(x => x.LastName)
                .HasColumnName("last_name");

            builder.Property(x => x.Email)
                .HasColumnName("email");

            builder.Property(x => x.ReservationId)
                .HasColumnName("reservation_id");

            builder.Property(x => x.Room)
                .HasColumnName("room");

            builder.Property(x => x.ReservationFrom)
                .HasColumnName("reservation_from");

            builder.Property(x => x.ReservationTo)
                .HasColumnName("reservation_to");
        }
    }
}
