using Domain.DTOs;
using System.Collections.Generic;

namespace AccessData.Commands
{
    public interface IHistoriaClinicaQueries
    {
        List<HistoriaClinica_RegistrosDTO> GetHistoriaClinicaByMascotaId(int mascotaId);
    }
}
