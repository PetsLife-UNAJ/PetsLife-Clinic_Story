using AccessData.Commands;
using AccessData.Queries.Repository;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TurnoService:ITurnoService
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
            Turno entity = new Turno
            {
             Fecha=model.Fecha, 
             HoraInicio = model.HoraInicio,
             Horafin = model.Horafin,
             MascotaId=model.MascotaId,
             CalendarioTurnoId=model.CalendarioTurnoId
            };

            var validator = new TurnoValidator();
            validator.ValidateAndThrow(entity);

            _repository.Add<Turno>(entity);
            return new ResponseTurno {
                Fecha = model.Fecha,
                HoraInicio = model.HoraInicio,
                Horafin = model.Horafin,
                MascotaId = model.MascotaId,
                CalendarioTurnoId = model.CalendarioTurnoId
            };
        }

        public List<ResponseTurno> GetAllByFecha(string fecha)
        {
            return _query.GetAllByFecha(fecha);
        }


    }
}
