using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }

        public DbSet<Villa> Villas { get; set; }


        public DbSet<NumeroVilla> NumeroVillas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la villa...",
                    ImagenUrl = "",
                    Ocupantes = 5,
                    MetroCuadrados = 50,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                 new Villa
                 {
                     Id = 2,
                     Nombre = "Preimium Villa Real",
                     Detalle = "Detalle de la villa premium...",
                     ImagenUrl = "",
                     Ocupantes = 4,
                     MetroCuadrados = 40,
                     Tarifa = 150,
                     Amenidad = "",
                     FechaCreacion = DateTime.Now,
                     FechaActualizacion = DateTime.Now
                 }
                );
        }
    }
}
