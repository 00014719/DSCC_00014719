using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
