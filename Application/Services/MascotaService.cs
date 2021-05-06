using AccessData.Commands;
using AccessData.Queries.Repository;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;

namespace Application.Services
{
    public interface IMascotaService
    {
        public ResponseMascota Create(MascotaDTO mascotaDto);
        public ResponseMascota GetMascotaById(int id);
    }

    public class MascotaService : IMascotaService
    {
        private readonly IGenericRepository _repository;
        private readonly IMascotaQueries _query;
        public MascotaService(IGenericRepository repository, IMascotaQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public ResponseMascota Create(MascotaDTO mascotaDto)
        {
            Mascota mascota = new Mascota
            {
                Nombre = mascotaDto.Nombre,
                Peso = mascotaDto.Peso,
                Edad = mascotaDto.Edad,
                ClienteId = mascotaDto.ClienteId
            };

            var validator = new MascotaValidator();
            validator.ValidateAndThrow(mascota);

            _repository.Add<Mascota>(mascota);

            return new ResponseMascota
            {
                MascotaId = mascota.MascotaId,
                Nombre = mascota.Nombre,
                Peso = mascota.Peso,
                Edad = mascota.Edad,
                ClienteId = mascota.ClienteId
            };
        }

        public ResponseMascota GetMascotaById(int id)
        {
            return _query.GetMascotaById(id);
        }
    }
}