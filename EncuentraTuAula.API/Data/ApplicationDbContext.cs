using Microsoft.EntityFrameworkCore;
using EncuentraTuAula.API.Models;

namespace EncuentraTuAula.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Sede> Sedes => Set<Sede>();
        public DbSet<Edificio> Edificios => Set<Edificio>();
        public DbSet<Aula> Aulas => Set<Aula>();

        // Configuración adicionale (Fluent API) para asegurar integridad
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ejemplo de buena práctica: Hacer el código obligatorio
            modelBuilder.Entity<Aula>().Property(a => a.Codigo).IsRequired().HasMaxLength(50);

        }
    }
}
