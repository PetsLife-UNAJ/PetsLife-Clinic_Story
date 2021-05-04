using Domain.DTOs;

namespace AccessData.Queries.Repository
{
    public interface IMascotaQueries
    {
        public ResponseMascota GetMascotaById(int Id);
    }
}