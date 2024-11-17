using csharp_EZReserve.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharp_EZReserve.Models.Configurations
{
    public class ReservationConfiguration: IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("reservations");

            builder.HasKey(r => r.ReservationId);

            builder.Property(r => r.ReservationId)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(r => r.CustomerId)
                .HasColumnName("customer_id")
                .IsRequired();

            builder.Property(r => r.Room)
                .HasColumnName("room")
                .IsRequired();

            builder.Property(r => r.From)
                .HasColumnName("from")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(r => r.To)
                .HasColumnName("to")
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
