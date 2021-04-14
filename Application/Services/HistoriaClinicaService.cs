using Domain.DTOs;
using Domain.ICommands;
using Domain.IQueries;
using Domain.Models;
using System;

namespace Application.Services
{
    public interface IHistoriaClinicaService
    {
        HistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO id);
        HistoriaClinica GetHistoriaClinicaByMascotaId(int mascotaId);
    }

    public class HistoriaClinicaService : IHistoriaClinicaService
    {
        private readonly IGenericRepository _repository;
        private readonly IHistoriaClinicaQueries _query;

        public HistoriaClinicaService(IGenericRepository repository, IHistoriaClinicaQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public HistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO id)
        {

            throw new NotImplementedException();
        }

        public HistoriaClinica GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            throw new NotImplementedException();
        }
    }
}
