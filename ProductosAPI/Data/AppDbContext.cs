using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductosAPI.Data;
using ProductosAPI.Models;

namespace ProductosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);

           

            // Data seeding
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Lapatop",
                    Descripcion = "Laptop Inspirion Dell 3535",
                    Precio = 25000.99m,
                    CantidadEnStock = 100,
                    FechaDeCreacion = DateTime.Now
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Teclado",
                    Descripcion = string.Empty,
                    Precio = 300,
                    CantidadEnStock = 200,
                    FechaDeCreacion = DateTime.Now 
                },
                new Producto
                {
                    Id = 3,
                    Nombre = "Mouse",
                    Descripcion = "Ergonomico color negro.",
                    Precio = 200.55m,
                    CantidadEnStock = 200,
                    FechaDeCreacion = DateTime.Now 
                },
                new Producto
                {
                    Id = 4,
                    Nombre = "Cargador",
                    Descripcion = string.Empty,
                    Precio = 500,
                    CantidadEnStock = 200,
                    FechaDeCreacion = DateTime.Now 
                });

        }

    }
}
