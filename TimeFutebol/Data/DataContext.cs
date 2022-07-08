using Microsoft.EntityFrameworkCore;
using TimeFutebol.Models;

namespace TimeFutebol.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Time> Times { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Time>().HasKey(x => x.Id);
            base.OnModelCreating(builder);
        }
    }
}
