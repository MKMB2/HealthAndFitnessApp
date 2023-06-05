using Microsoft.EntityFrameworkCore;

namespace HealthAndFitnessApp.Models
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }
        public DbSet<Model1> models { get; set; }
    }
}
