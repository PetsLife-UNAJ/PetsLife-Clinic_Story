using AccessData.Commands;
using AccessData.Queries.Repository;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Application.Services
{
    public class TurnoService : ITurnoService
    {
        private readonly IGenericRepository _repository;
        private readonly ITurnoQueries _query;
        public TurnoService(IGenericRepository repository, ITurnoQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public ResponseTurno Create(TurnoDTO model)
        {
            DateTime fecha = Convert.ToDateTime(model.Fecha);
            DateTime horaInicio = Convert.ToDateTime(model.HoraInicio);
            DateTime horaFin = Convert.ToDateTime(model.Horafin);

            DateTime inicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, horaInicio.Hour, horaInicio.Minute, 0);
            DateTime fin = new DateTime(fecha.Year, fecha.Month, fecha.Day, horaFin.Hour, horaFin.Minute, 0);

            Turno entity = new Turno
            {
                Fecha = fecha,
                HoraInicio = inicio,
                Horafin = fin,
                MascotaId = model.MascotaId,
                VeterinarioId = model.VeterinarioId
            };

            //var validator = new TurnoValidator();
            //validator.ValidateAndThrow(entity);

            _repository.Add<Turno>(entity);
            _repository.SaveChanges();
            return new ResponseTurno
            {
                Fecha = fecha,
                HoraInicio = inicio,
                Horafin = fin,
                MascotaId = entity.MascotaId,
                VeterinarioId = entity.VeterinarioId
            };
        }

        public List<ResponseTurno> GetAllByFecha(string fecha)
        {
            return _query.GetAllByFecha(fecha);
        }
    }
}