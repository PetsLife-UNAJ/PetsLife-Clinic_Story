using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Registro
    {
        [Required] public int RegistroId { get; set; }
        [Required] public string Analisis { get; set; }

        //Foreign Key
        public HistoriaClinica HistoriaClinica { get; set; }
        public int HistoriaClinicaId { get; set; }
    }
}
