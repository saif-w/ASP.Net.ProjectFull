using App.Project.Data.Tabels;
using Microsoft.EntityFrameworkCore;

namespace App.Project.Data
{
    public class HRDBContext : DbContext
    {
        public HRDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
    }
}
