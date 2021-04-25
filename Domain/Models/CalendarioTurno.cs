using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CalendarioTurno
    {
        public int CalendarioTurnoId { get; set; }
        public string Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime Horafin { get; set; }
        
        //FKs       
        public ICollection<Turno> Turnos{ get; set; }

        //public int VeterinarioId { get; set; }
        //public Veterinario Veterinario { get; set; }
    }
}
