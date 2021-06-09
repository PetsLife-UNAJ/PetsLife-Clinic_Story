using System;

namespace Domain.DTOs
{
    public class ResponseTurnoData
    {
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime Horafin { get; set; }

        public int VeterinarioId { get; set; }
        public string VeterinarioNombre { get; set; }
        public string VeterinarioApellido { get; set; }
        public int ConsultorioNumero { get; set; }

        public int MascotaId { get; set; }
        public string MascotaNombre { get; set; }

        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteApellido { get; set; }
        public string ClienteTelefono { get; set; }
    }
}