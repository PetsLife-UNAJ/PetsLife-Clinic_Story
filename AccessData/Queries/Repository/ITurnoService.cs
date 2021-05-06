using Domain.DTOs;
using System.Collections.Generic;

namespace AccessData.Queries.Repository
{
    public interface ITurnoService
    {
        public ResponseTurno Create(TurnoDTO model);
        public List<ResponseTurno> GetAllByFecha(string fecha);






    }
}
