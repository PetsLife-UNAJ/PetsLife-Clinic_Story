using System;

namespace Domain.DTOs
{
    public class TurnoDTO
    {
        public string Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string Horafin { get; set; }

        public int VeterinarioId { get; set; }
        public int MascotaId { get; set; }
    }
}