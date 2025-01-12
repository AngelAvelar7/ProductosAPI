using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductosAPI.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Error - El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Error - El nombre debe tener entre 3 y 100 caracteres.")]
        public string Nombre { get; set; }

        [StringLength(500, ErrorMessage = "Error - La descripcion no puede tener más de 500 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Error - El precio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Error - El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Error - La cantidad en stock es obligatoria.")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad en stock no puede ser negativa.")]
        public int CantidadEnStock { get; set; }

        public DateTime FechaDeCreacion { get; set; }

    }
}
