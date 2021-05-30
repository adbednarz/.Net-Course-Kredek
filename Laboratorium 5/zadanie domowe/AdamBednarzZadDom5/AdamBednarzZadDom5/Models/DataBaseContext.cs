using Microsoft.EntityFrameworkCore;

namespace AdamBednarzZadDom5.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            

        }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Commander> Commanders { get; set; }

        public DbSet<Age> Ages { get; set; }
    }
}
