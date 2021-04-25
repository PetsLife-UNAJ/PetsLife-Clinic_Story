using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Veterinaria
    {
        public int VeterinariaId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //FKs
        public List<Consultorio> Consultorios { get; set; }

    }
}
