using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductosAPI.Models;
using ProductosAPI.Data;
using Xunit;

namespace ProductosAPI.Tests
{
    public class Productotests
    {
        private readonly AppDbContext _context;

        public Productotests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new AppDbContext(options);
        }

        [Fact]
        public void NoDeberiaCrearProductoConPrecioNegativo()
        {
            // Arrange
            var producto = new Producto
            {
                Nombre = "Producto con Precio Negativo",
                Descripcion = "Producto con precio negativo",
                Precio = -5.00m, // Precio negativo
                CantidadEnStock = 10,
                FechaDeCreacion = DateTime.Now
            };
            var exception = Assert.Throws<ArgumentException>(() => _context.Add(producto));
            Assert.Contains("Producto inválido", exception.Message);
        }

        [Fact]
        public void NoDeberiaCrearProductoConNombreMenorATresCaracteres()
        {
            // Arrange
            var producto = new Producto
            {
                Nombre = "AB", // Nombre con menos de 3 caracteres
                Descripcion = "Producto con nombre corto",
                Precio = 100.00m,
                CantidadEnStock = 5,
                FechaDeCreacion = DateTime.Now
            };

            var exception = Assert.Throws<ArgumentException>(() => _context.Add(producto));
            Assert.Contains("Producto inválido", exception.Message);
        }
    }
}
