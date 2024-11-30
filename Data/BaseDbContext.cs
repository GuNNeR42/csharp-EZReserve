using csharp_EZReserve.Models.Configurations;
using csharp_EZReserve.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace csharp_EZReserve.Data
{
    public abstract class BaseDbContext : DbContext
    {
        protected readonly IConfiguration _config; 

        protected BaseDbContext(IConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        // Child classes implement this to specify the connection string and provider.
        protected abstract void ConfigureDatabase(DbContextOptionsBuilder optionsBuilder);

        // Initiale DbSets for models and set data source
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<CustomerReservationView> CustomerReservationViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            ConfigureDatabase(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerReservationViewConfiguration());
        }
    }
}
