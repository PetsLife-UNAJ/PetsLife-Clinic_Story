using AccessData.Commands;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Models;
using FluentValidation;
using System;

namespace Application.Services
{
    public interface IRegistroService
    {
        ResponseRegistro CreateRegistro(RegistroDTO registro);
    }

    public class RegistroService : IRegistroService
    {
        private readonly IGenericRepository _repository;

        public RegistroService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public ResponseRegistro CreateRegistro(RegistroDTO registro)
        {
            Registro entity = new Registro
            {
                HistoriaClinicaId = registro.HistoriaClinicaId,
                Analisis = registro.Analisis,
                FechaCreacion = DateTime.Now
            };

            var validator = new RegistroValidator();
            validator.ValidateAndThrow(entity);

            _repository.Add<Registro>(entity);
            _repository.SaveChanges();

            return new ResponseRegistro
            {
                RegistroId = entity.RegistroId,
                Analisis = entity.Analisis,
                HistoriaClinicaId = entity.HistoriaClinicaId
            };
        }
    }
}