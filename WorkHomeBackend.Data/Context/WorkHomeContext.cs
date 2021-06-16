using Microsoft.EntityFrameworkCore;

namespace WorkHomeBackend.Data.Context
{
    public class WorkHomeContext : DbContext
    {
        public WorkHomeContext(DbContextOptions options):base(options)
        {   

        }

        public DbSet<Routine> Routine { get; set; }
        public DbSet<Training> Training { get; set; }
    }
}
