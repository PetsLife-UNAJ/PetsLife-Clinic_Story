using Domain.Models;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }

        //Fks
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public List<Turno> Turno { get; set; }

        public HistoriaClinica HistoriaClinica { get; set; }
    }
}