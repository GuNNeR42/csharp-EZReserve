using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;
using csharp_EZReserve.Models.Factories;

namespace csharp_EZReserve.Models.Seeders
{
    public class CustomerSeeder : BaseSeeder<Customer>
    {
        private readonly BaseDbContext _context;

        public CustomerSeeder(BaseDbContext context, bool withReservations = false) : base(context, new CustomerFactory(withReservations))
        {
            _context = context;
        }

        public override async Task SeedAsync(int? count = null)
        {
            var customers = Factory.Generate(count ?? DefaultCount);
            await SaveChangesWithIdentityInsertAsync(_context.Customers, customers);
        }
    }
}
