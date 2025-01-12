using ProductosAPI.Models;

namespace ProductosAPI.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetProductos (string nombre, decimal? precioMin, decimal? precioMax);
        Task<Producto> GetProductoById(int id);
        Task<Producto> InsertProducto(Producto producto);
        Task<bool> UpdateProducto(int id, Producto producto);
        Task<bool> DeleteProducto(int id);

    }
}
