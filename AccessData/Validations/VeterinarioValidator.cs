using Domain.Entities;
using FluentValidation;

namespace AccessData.Validations
{
    public class VeterinarioValidator : AbstractValidator<Veterinario>
    {
        public VeterinarioValidator()
        {
            RuleFor(x => x.Nombre).NotNull().NotEmpty().WithMessage("El nombre no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Apellido).NotNull().NotEmpty().WithMessage("El apellido no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Dni).NotNull().NotEmpty().WithMessage("El Dni no debe quedar vacio.")
                .MaximumLength(12).WithMessage("El maximo es 12 caracteres.");

            RuleFor(x => x.FechaNacimiento).NotNull().NotEmpty().WithMessage("La fecha de nacimiento no debe quedar vacio.");

            RuleFor(x => x.Sexo).NotNull().NotEmpty().WithMessage("El sexo no debe quedar vacio.")
                .MaximumLength(1).WithMessage("El maximo es 1 caracter.");

            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("El email no debe quedar vacio.")
               .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Telefono).NotNull().NotEmpty().WithMessage("El email no debe quedar vacio.")
               .MaximumLength(12).WithMessage("El maximo es 12 caracteres.");

            RuleFor(x => x.Matricula).NotNull().NotEmpty().WithMessage("La matricula no debe quedar vacio.")
               .MaximumLength(15).WithMessage("El maximo es 15 caracteres.");


        }
    }
}
