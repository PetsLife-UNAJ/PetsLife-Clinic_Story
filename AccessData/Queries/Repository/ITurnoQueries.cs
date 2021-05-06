using Domain.DTOs;
using System.Collections.Generic;

namespace AccessData.Queries.Repository
{
    public interface ITurnoQueries
    {
        public List<ResponseTurno> GetAllByFecha(string fecha);
    }
}
