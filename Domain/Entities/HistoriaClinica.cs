using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Models
{
    public class HistoriaClinica
    {
        public int HistoriaClinicaId { get; set; }

        //Fks
        public List<Registro> Registros { get; set; }
        public int MascotaId { get; set; }
        public Mascota Mascota { get; set; }
    }
}
