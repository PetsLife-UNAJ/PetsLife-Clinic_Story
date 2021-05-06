using AccessData.Commands;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;
using System;

namespace Application.Services
{
    public interface IVeterinarioService
    {
        public ResponseVeterinario Create(VeterinarioDTO veterinarioDTO);
    }

    public class VeterinarioService : IVeterinarioService
    {
        private readonly IGenericRepository _repository;

        public VeterinarioService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public ResponseVeterinario Create(VeterinarioDTO veterinarioDTO)
        {
            Veterinario veterinario = new Veterinario
            {
                Nombre = veterinarioDTO.Nombre,
                Apellido = veterinarioDTO.Apellido,
                Dni = veterinarioDTO.Dni,
                FechaNacimiento = veterinarioDTO.FechaNacimiento,
                Sexo = veterinarioDTO.Sexo,
                Email = veterinarioDTO.Email,
                Domicilio = veterinarioDTO.Domicilio,
                Telefono = veterinarioDTO.Telefono,
                Matricula = veterinarioDTO.Matricula,
                ConsultorioId = veterinarioDTO.ConsultorioId
            };

            var validator = new VeterinarioValidator();
            validator.ValidateAndThrow(veterinario);

            _repository.Add<Veterinario>(veterinario);

            return new ResponseVeterinario
            {
                VeterinarioId = veterinario.VeterinarioId,
                Nombre = veterinario.Nombre,
                Apellido = veterinario.Apellido,
                Dni = veterinario.Dni,
                FechaNacimiento = veterinario.FechaNacimiento,
                Sexo = veterinario.Sexo,
                Email = veterinario.Email,
                Domicilio = veterinario.Domicilio,
                Telefono = veterinario.Telefono,
                Matricula = veterinario.Matricula,
                ConsultorioId = veterinario.ConsultorioId
            };
        }
    }
}