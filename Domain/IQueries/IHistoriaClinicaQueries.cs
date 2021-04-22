using Domain.DTOs;
using System.Collections.Generic;

namespace Domain.IQueries
{
    public interface IHistoriaClinicaQueries
    {
        List<HistoriaClinica_RegistrosDTO> GetHistoriaClinicaByMascotaId(int mascotaId);
    }
}
