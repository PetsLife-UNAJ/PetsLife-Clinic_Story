using Domain.DTOs;
using System;
using System.Collections.Generic;

namespace AccessData.Queries.Repository
{
    public interface ITurnoService
    {
        public ResponseTurno Create(TurnoDTO model);
        public List<ResponseTurnoData> GetAllByFecha(DateTime? fecha);
        public List<ResponseTurno> GetTurnosByVeterinarioId(int veterinarioId);
    }
}