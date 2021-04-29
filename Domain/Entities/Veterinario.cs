using Domain.Models;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Veterinario
    {
        public int VeterinarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Matricula { get; set; }

        //fk
        public Consultorio Consultorio { get; set; }
        public int ConsultorioId { get; set; }

        public List<CalendarioTurno> CalendarioTurnos { get; set; }

    }
}
