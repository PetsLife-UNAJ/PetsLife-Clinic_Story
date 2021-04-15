using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class HistoriaClinica
    {
        [Required] public int HistoriaClinicaId { get; set; }
        [Required] public int MascotaId { get; set; }

        public List<Registro> Registros { get; set; }

    }
}
