using Domain.Models;
using FluentValidation;

namespace AccessData.Validations
{
    public class TurnoValidator : AbstractValidator<Turno>
    {
        public TurnoValidator()
        {
            RuleFor(x => x.Fecha).NotEmpty().WithMessage("El Nº de historia clinica no debe quedar vacio.");

            RuleFor(x => x.HoraInicio).NotEmpty().WithMessage("La hora de inicio no debe quedar vacio.");

            RuleFor(x => x.Horafin).NotEmpty().WithMessage("La hora de fin no debe quedar vacio.");

            RuleFor(x => x.MascotaId).NotEmpty().WithMessage("El Nº de mascota no debe quedar vacio.");
        }
    }
}