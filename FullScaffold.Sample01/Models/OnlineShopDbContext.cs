using Microsoft.EntityFrameworkCore;

namespace FullScaffold.Sample01.Models
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> people { get; set; }
    }
}
