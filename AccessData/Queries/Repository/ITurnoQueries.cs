using Domain.DTOs;
using System;
using System.Collections.Generic;

namespace AccessData.Queries.Repository
{
    public interface ITurnoQueries
    {
        public List<ResponseTurno> GetAllByFecha(DateTime? fecha);
    }
}