using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Dia
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}