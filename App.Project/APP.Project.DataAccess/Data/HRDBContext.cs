using APP.Project.DataAccess.Data.Tabels;
using Microsoft.EntityFrameworkCore;

namespace APP.Project.DataAccess.Data
{
    public class HRDBContext : DbContext
    {
        public HRDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
    }
}
