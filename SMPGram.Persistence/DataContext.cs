

using Microsoft.EntityFrameworkCore;
using SMPGram.Domain;

namespace SMPGram.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
