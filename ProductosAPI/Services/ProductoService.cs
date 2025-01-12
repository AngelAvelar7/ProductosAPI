using ProductosAPI.Data;
using ProductosAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductosAPI.Services
{
    public class ProductoService : IProductoService
    {
        private readonly AppDbContext _dbContext;
        public ProductoService (AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Producto>>GetProductos(string nombre, decimal? precioMin, decimal? precioMax )
        {
            var query = _dbContext.Productos.AsQueryable();

            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(p => p.Nombre.Contains(nombre));
            }
            if (precioMin.HasValue)
            {
                query = query.Where(p => p.Precio >= precioMin.Value);
            }
            if (precioMax.HasValue)
            {
                query = query.Where(p => p.Precio <= precioMax.Value);
            }

            return await query.ToListAsync();
        }

        public async Task<Producto> GetProductoById(int id)
        {
            return await _dbContext.Productos.FindAsync(id);
        }

        public async Task<Producto> InsertProducto(Producto producto)
        {
            
            _dbContext.Productos.Add(producto);
            await _dbContext.SaveChangesAsync();
            return producto;
        }

        public async Task<bool> UpdateProducto(int id, Producto producto)
        {
            var productoEncontrado = await _dbContext.Productos.FindAsync(id);
            if (productoEncontrado == null)
            {
                return false;
            }

            productoEncontrado.Nombre = producto.Nombre;
            productoEncontrado.Descripcion = producto.Descripcion;
            productoEncontrado.Precio = producto.Precio;
            productoEncontrado.CantidadEnStock = producto.CantidadEnStock;

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProducto(int id)
        {
            var producto = await _dbContext.Productos.FindAsync(id);
            if (producto == null)
            {
                return false;
            }

            _dbContext.Productos.Remove(producto);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
