using csharp_EZReserve.Data;
using csharp_EZReserve.Models.Entities;

namespace csharp_EZReserve.Services
{
    public abstract class BaseExporter
    {
        public string FileName { get; protected set; }
        public bool Success { get; protected set; }
        protected string _exportDirectory = string.Empty;
        protected readonly BaseDbContext _dbContext;
        protected string ExportPath => Path.Combine(_exportDirectory, FileName);
        protected abstract string FileExtension { get; }

        public BaseExporter(BaseDbContext dbContext)
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

        protected virtual List<CustomerReservationView> GetFilteredReservations(DateTime from, DateTime to)
        {
            return _dbContext.Set<CustomerReservationView>()
                .Where(r => r.ReservationFrom >= from && r.ReservationTo <= to)
                .ToList();
        }

        public virtual void Export(DateTime from, DateTime to)
        {
            ValidateAndSetupExportPath();
            ValidateAndSetupFileName(from, to);

            var filteredData = GetFilteredReservations(from, to);
            if (!filteredData.Any())
                throw new InvalidOperationException("No data to export for the specified range.");

            // Let child classes implement the actual export logic
            ExportData(filteredData);

            Success = true;
        }

        protected virtual void ValidateAndSetupExportPath()
        {
            if (string.IsNullOrEmpty(_exportDirectory))
            {
                _exportDirectory = "./";
                return;
            }

            if (!Directory.Exists(_exportDirectory))
            {
                try
                {
                    Directory.CreateDirectory(_exportDirectory);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException($"Failed to create export directory: {ex.Message}");
                }
            }
        }

        protected virtual void ValidateAndSetupFileName(DateTime from, DateTime to)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = $"Export_{from:dd_MM_yyyy_HH_mm}_{to:dd_MM_yyyy_HH_mm}{FileExtension}";
            }
            else
            {
                FileName = !FileName.EndsWith(FileExtension, StringComparison.OrdinalIgnoreCase)
                    ? $"{FileName}{FileExtension}"
                    : FileName;
            }
        }

        protected abstract void ExportData(List<CustomerReservationView> data);
    }
}
