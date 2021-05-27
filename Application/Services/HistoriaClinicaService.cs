using AccessData.Commands;
using Domain.DTOs;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IHistoriaClinicaService
    {
        List<HistoriaClinica_RegistrosDTO> GetHistoriaClinicaByMascotaId(int mascotaId);
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

        public List<HistoriaClinica_RegistrosDTO> GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            return _query.GetHistoriaClinicaByMascotaId(mascotaId);
        }
    }
}