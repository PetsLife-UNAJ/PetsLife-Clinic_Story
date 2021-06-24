using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;

namespace AccessData.Queries.Repository
{
    public interface ITurnoQueries
    {
        public List<ResponseTurnoData> GetAllByFecha(DateTime? fecha);
        public List<int> ListVeterinariosDisponibles(DateTime fecha, DateTime horaInicio);
        public List<ResponseTurnoData> GetByVeterinarioId(int veterinarioId, DateTime fecha);
        public Turno getTurnoById(int turnoId);
    }
}