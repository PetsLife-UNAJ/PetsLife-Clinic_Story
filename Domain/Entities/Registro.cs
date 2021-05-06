using Domain.Entities;
using System;

namespace Domain.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string Analisis { get; set; }
        public DateTime FechaCreacion { get; set; }

        //Foreign Key
        public HistoriaClinica HistoriaClinica { get; set; }

        public int HistoriaClinicaId { get; set; }

        public Tratamiento Tratamiento { get; set; }
    }
}