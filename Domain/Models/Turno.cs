using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Turno
    {
        public int TurnoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime Horafin { get; set; }

        //Fks
        public int MascotaId { get; set; }
        public int VeterinarioId { get; set; }
        
        public int CalendarioTurnoId { get; set; }
        public CalendarioTurno CalendarioTurno { get; set; }

        //public int VeterinarioId { get; set; }
        //public Veterinario Veterinario { get; set; }




    }
}
