using System;

namespace Domain.DTOs
{
    public class HistoriaClinica_RegistrosDTO
    {
        public int HistoriaClinicaId { get; set; }
        public int RegistroId { get; set; }
        public string Tratamiento { get; set; }
        public string Analisis { get; set; }
        public int MascotaId { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}