using Domain.Models;
using FluentValidation;

namespace AccessData.Validations
{
    public class RegistroValidator : AbstractValidator<Registro>
    {
        public RegistroValidator()
        {
            RuleFor(x => x.Analisis).NotNull().WithMessage("El nombre no debe quedar vacio.")
                .MaximumLength(100).WithMessage("El maximo es 100 caracteres.");
        }
    }
}
