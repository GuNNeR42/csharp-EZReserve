using csharp_EZReserve.Data;

namespace csharp_EZReserve.Services
{
    public class GraphDataService
    {
        private BaseDbContext _dbContext;

        public GraphDataService(BaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<(string Room, int Count)> FilterValues(DateTime from, DateTime to, bool orderByUsage = true)
        {
            var query = _dbContext.Reservations
                .Where(r => r.From >= from && r.To <= to) // Filter reservations within the date range
                .GroupBy(r => r.Room) // Group reservations by room
                .Select(g => new { Room = g.Key, Count = g.Count() }); // Use anonymous objects

            // Apply ordering based on the configuration
            if (orderByUsage)
            {
                query = query.OrderByDescending(x => x.Count).ThenBy(x => x.Room);
            }
            else
            {
                query = query.OrderBy(x => x.Room);
            }

            // Convert to list and map to tuples
            return query
                .ToList()
                .Select(x => (x.Room, x.Count))
                .ToList();
        }
    }
}
