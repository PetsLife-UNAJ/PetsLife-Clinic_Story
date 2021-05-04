using System.Collections.Generic;

namespace Domain.DTOs
{
    public class GetClienteDTO
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<ResponseMascota> Mascotas { get; set; }
    }
}