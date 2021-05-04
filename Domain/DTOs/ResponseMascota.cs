namespace Domain.DTOs
{
    public class ResponseMascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }

        public int ClienteId { get; set; }
    }
}