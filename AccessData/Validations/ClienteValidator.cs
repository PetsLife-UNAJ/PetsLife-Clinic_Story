using Domain.Entities;
using FluentValidation;

namespace AccessData.Validations
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Nombre).NotNull().WithMessage("El nombre no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Apellido).NotNull().WithMessage("El apellido no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Email).NotNull().WithMessage("El email no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Dni).NotNull().WithMessage("El DNI no debe quedar vacio.")
                .WithMessage("El maximo es 8 caracteres.");

            RuleFor(x => x.Direccion).NotNull().WithMessage("La dirección no debe quedar vacio.")
                .WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Telefono).NotNull().WithMessage("El telefono no debe quedar vacio.")
                .WithMessage("El maximo es 12 caracteres.");
        }
    }
}

