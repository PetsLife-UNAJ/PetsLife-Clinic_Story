using Domain.Models;
using FluentValidation;

namespace AccessData.Validations
{
    public class HistoriaClinicaValidator : AbstractValidator<HistoriaClinica>
    {
        public HistoriaClinicaValidator()
        {
            RuleFor(x => x.HistoriaClinicaId).NotEmpty().WithMessage("El Nº de historia clinica no debe quedar vacio.");

            RuleFor(x => x.MascotaId).NotEmpty().WithMessage("El Nº de mascota no debe quedar vacio.");
        }
    }
}