using AccessData.Commands;
using Domain.DTOs;
using Domain.Models;
using System.Collections.Generic;

namespace Application.Services
{
    public interface IHistoriaClinicaService
    {
        ResponseHistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO id);
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

        public ResponseHistoriaClinica CreateHistoriaClinica(HistoriaClinicaDTO historiaclinica)
        {

            HistoriaClinica hc = new HistoriaClinica
            {
                MascotaId = historiaclinica.MascotaId
            };

            _repository.Add<HistoriaClinica>(hc);

            return new ResponseHistoriaClinica
            {
                Id = hc.HistoriaClinicaId,
                MascotaId = hc.MascotaId
            };
        }


        public List<HistoriaClinica_RegistrosDTO> GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            return _query.GetHistoriaClinicaByMascotaId(mascotaId);
        }
    }
}
