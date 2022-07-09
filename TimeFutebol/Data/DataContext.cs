using Microsoft.EntityFrameworkCore;
using TimeFutebol.Models;

namespace TimeFutebol.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TimeModel> Times { get; set; }
        public DbSet<JogadorModel> Jogador { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TimeModel>().ToTable("Time");
            builder.Entity<TimeModel>().HasKey(t => t.IdTime);
           
            builder.Entity<JogadorModel>().ToTable("Jogador");
            builder.Entity<JogadorModel>().HasKey(j => j.IdJogador);
            base.OnModelCreating(builder);

            
        }
    }
}
