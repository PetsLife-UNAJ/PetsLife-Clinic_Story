using Domain.Entities;
using FluentValidation;

namespace AccessData.Validations
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Nombre).NotNull().NotEmpty().WithMessage("El nombre no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Apellido).NotNull().NotEmpty().WithMessage("El apellido no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("El email no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Dni).NotNull().NotEmpty().WithMessage("El DNI no debe quedar vacio.")
                .MaximumLength(8).WithMessage("El maximo es 8 caracteres.");

            RuleFor(x => x.Direccion).NotNull().NotEmpty().WithMessage("La dirección no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Telefono).NotNull().NotEmpty().WithMessage("El telefono no debe quedar vacio.")
                .MaximumLength(12).WithMessage("El maximo es 12 caracteres.");
        }
    }
}

