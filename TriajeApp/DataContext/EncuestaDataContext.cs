using Microsoft.EntityFrameworkCore;
using TriajeApp.Models;

namespace TriajeApp.DataContext
{
    public class EncuestaDataContext : DbContext
    {
        public DbSet<Encuesta> Encuestas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=;DataBase=TriajeApp;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EncuestaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
