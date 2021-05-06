using AccessData.Commands;
using AccessData.Queries.Repository;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IClienteService
    {
        GenericCreatedResponseDto Create(ClienteDTO model);
        GetClienteDTO GetClienteById(int id);

        List<GetClienteDTO> GetAll();
    }

    public class ClienteService : IClienteService
    {
        private readonly IGenericRepository _repository;
        private readonly IClienteQueries _query;
        public ClienteService(IGenericRepository repository, IClienteQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public GenericCreatedResponseDto Create(ClienteDTO model)
        {
            Cliente entity = new Cliente
            {
                Nombre = model.Nombre,
                Apellido = model.Apellido,
                Email = model.Email,
                Dni = model.Dni,
                Direccion = model.Direccion,
                Telefono = model.Telefono
            };

            var validator = new ClienteValidator();
            validator.ValidateAndThrow(entity);

            _repository.Add<Cliente>(entity);
            return new GenericCreatedResponseDto { Entity = "Cliente", Id = entity.ClienteId.ToString() };

        }

        public List<GetClienteDTO> GetAll()
        {
            return _query.GetAll();
        }

        public GetClienteDTO GetClienteById(int id)
        {
            return _query.GetClienteById(id);
        }
    }
}