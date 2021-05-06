using Domain.Models;

namespace Domain.Entities
{
    public class Tratamiento
    {
        public int TratamientoId { get; set; }
        public string Descripcion { get; set; }

        public Registro Registro { get; set; }
        public int RegistroId { get; set; }
    }
}