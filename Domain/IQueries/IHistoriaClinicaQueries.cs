using Domain.Models;

namespace Domain.IQueries
{
    public interface IHistoriaClinicaQueries
    {
        HistoriaClinica GetHistoriaClinicaByMascotaId(int mascotaId);
    }
}
