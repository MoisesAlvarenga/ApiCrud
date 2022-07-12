using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            builder.Entity<JogadorModel>().HasIndex(x => x.Camisa).IsUnique();
            base.OnModelCreating(builder);

            
        }

        internal Task<IEnumerable<JogadorModel>> FindAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
