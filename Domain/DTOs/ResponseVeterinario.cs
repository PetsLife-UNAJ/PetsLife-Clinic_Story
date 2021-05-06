namespace Domain.DTOs
{
    public class ResponseVeterinario
    {
        public int VeterinarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Matricula { get; set; }

        public int ConsultorioId { get; set; }
    }
}