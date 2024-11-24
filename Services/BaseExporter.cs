using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;

namespace csharp_EZReserve.Services
{
    public abstract class BaseExporter
    {
        public string FileName { get; protected set; }
        public bool Success { get; protected set; }
        protected string _exportDirectory = string.Empty;
        protected readonly SQLiteDbContext _dbContext;
        protected string _exportPath => Path.Combine(_exportDirectory, FileName);

        public BaseExporter(SQLiteDbContext dbContext)
        {
            _dbContext = dbContext;
            FileName = string.Empty;
            Success = false;
        }

        public BaseExporter ToDirectory(string directory)
        {
            _exportDirectory = directory;
            return this;
        }

        public BaseExporter WithName(string name)
        {
            FileName = name;
            return this;
        }

        public BaseExporter Reset()
        {
            _exportDirectory = string.Empty;
            Success = false;
            FileName = string.Empty;
            return this;
        }

        protected List<CustomerReservationView> GetFilteredReservations(DateTime from, DateTime to)
        {
            return _dbContext.Set<CustomerReservationView>()
                .Where(r => r.ReservationFrom >= from && r.ReservationTo <= to)
                .ToList();
        }

        public abstract void Export(DateTime from, DateTime to);
    }
}
