using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        // DataContext constructor 
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // DbSets represent table names in the database
        public DbSet<Activity> Activities { get; set; }
    }
}