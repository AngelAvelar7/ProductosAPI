using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductosAPI.Data;
using ProductosAPI.Models;
using ProductosAPI.Services;

namespace ProductosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly IProductoService _ProductoService;

        public ProductoController (IProductoService productoService)
        {
            _ProductoService = productoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos([FromQuery] string? nombre, [FromQuery] decimal? precioMin, [FromQuery] decimal? precioMax)
        {
            var productos = await _ProductoService.GetProductos(nombre, precioMin, precioMax);
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducto(int id)
        {
            var producto = await _ProductoService.GetProductoById(id);
            if (producto == null)
            {
                return NotFound(new {message = "Producto no encontrado."});
            }

            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> PostProducto([FromBody] Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var nuevoProducto = await _ProductoService.InsertProducto(producto);            
            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, nuevoProducto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, [FromBody] Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest(new {message = "El ID del producto no coincide."});
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var actualizado = await _ProductoService.UpdateProducto(id, producto);
            if (!actualizado)
            {
                return NotFound(new { message = "Producto no encontrado." });
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto (int id)
        {
            var eliminado = await _ProductoService.DeleteProducto(id);
            if (!eliminado)
            {
                return NotFound(new {message = "Producto no encontrado."});
            }
            return NoContent();

        }

             
    }
}
