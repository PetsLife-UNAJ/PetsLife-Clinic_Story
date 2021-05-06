﻿using AccessData.Commands;
using AccessData.Queries.Repository;
using AccessData.Validations;
using Domain.DTOs;
using Domain.Entities;
using Domain.Models;
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

            _repository.Add<Mascota>(mascota);

            var validatorMascota = new MascotaValidator();
            validatorMascota.ValidateAndThrow(mascota);

            _repository.SaveChanges();

            HistoriaClinica hc = new HistoriaClinica
            {
                MascotaId = mascota.MascotaId
            };

            var validatorHHCC = new HistoriaClinicaValidator();
            validatorHHCC.ValidateAndThrow(hc);

            _repository.Add<HistoriaClinica>(hc);
            _repository.SaveChanges();

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