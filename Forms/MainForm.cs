using csharp_EZReserve.Data;

namespace csharp_EZReserve.Forms
{
    public partial class MainForm : Form
    {
        private readonly SQLiteDbContext _dbContext;
        public MainForm(SQLiteDbContext dbContext)
        {
            _dbContext = dbContext;

            InitializeComponent();
        }
    }
}
