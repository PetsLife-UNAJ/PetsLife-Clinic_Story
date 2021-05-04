using AccessData.Commands;
using AccessData.Queries.Repository;
using Domain.DTOs;
using Domain.Entities;
using System;

namespace Application.Services
{
    public interface IMascotaService
    {
        public ResponseMascota Create(MascotaDTO mascotaDto);
        public GetClienteDTO GetMascotasByClienteId(int clienteId);
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

        //public List<Mascota> GetAll()
        //{ }

        public GetClienteDTO GetMascotasByClienteId(int clienteId)
        {
            //return _query.GetById(id);
            throw new Exception();
        }
    }
}