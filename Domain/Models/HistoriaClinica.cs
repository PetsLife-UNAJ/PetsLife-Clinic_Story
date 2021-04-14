using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class HistoriaClinica
    {
        [Required] public int Id { get; set; }
        [Required] public int MascotaId { get; set; }

        public List<Registro> Registros { get; set; }

    }
}
