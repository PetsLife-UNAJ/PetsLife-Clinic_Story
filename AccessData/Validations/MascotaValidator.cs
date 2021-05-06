using Domain.Entities;
using FluentValidation;

namespace AccessData.Validations
{
    public class MascotaValidator : AbstractValidator<Mascota>
    {
        public MascotaValidator()
        {
            RuleFor(x => x.Nombre).NotNull().WithMessage("El nombre no debe quedar vacio.")
                .MaximumLength(50).WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Edad).NotEmpty().WithMessage("La edad no debe quedar vacio.");

            RuleFor(x => x.Peso).NotNull().WithMessage("El peso no debe quedar vacio.");
        }
    }
}
