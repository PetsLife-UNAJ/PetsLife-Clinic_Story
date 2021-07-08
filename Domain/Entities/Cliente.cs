using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClienteId { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //Fks
        public List<Mascota> Mascotas { get; set; }
    }
}