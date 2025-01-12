using FluentValidation;
using ProductosAPI.Models;

namespace ProductosAPI.Validators
{
    public class ProductoValidator : AbstractValidator<Producto>
    {
        public ProductoValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("Error - El nombre es obligatorio.")
                .Length(3, 100).WithMessage("Error - El nombre debe tener entre 3 y 100 caracteres.");

            RuleFor(p => p.Precio)
                .NotEmpty().WithMessage("Error - El precio es obligaorio.")
                .GreaterThan(0).WithMessage("Error - El precio debe ser mayoy a 0.");

            RuleFor(p => p.Precio)
                .NotEmpty().WithMessage("Error - La cantidad en stock es obligatoria")
                .GreaterThan(0).WithMessage("Error - La cantidad en stock no puede ser negativa");
        }
    }
}
