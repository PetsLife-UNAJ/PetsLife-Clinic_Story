using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string Analisis { get; set; }

        //Foreign Key
        public HistoriaClinica HistoriaClinica { get; set; }
        public int HistoriaClinicaId { get; set; }
    }
}
