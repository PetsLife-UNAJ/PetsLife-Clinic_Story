using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
