using Domain.Entities;
using System;

namespace Domain.Models
{
    public class Turno
    {
        public int TurnoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime Horafin { get; set; }

        //Fks
        public int MascotaId { get; set; }

        public Mascota Mascota { get; set; }

        public int VeterinarioId { get; set; }
        public Veterinario Veterinario { get; set; }
    }
}