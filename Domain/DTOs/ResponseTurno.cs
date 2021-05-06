using System;

namespace Domain.DTOs
{
    public class ResponseTurno
    {
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime Horafin { get; set; }


        public int MascotaId { get; set; }


        public int CalendarioTurnoId { get; set; }

    }
}
