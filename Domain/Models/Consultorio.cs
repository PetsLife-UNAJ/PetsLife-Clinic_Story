﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Consultorio
    {
        public int ConsultorioId { get; set; }
        public int Numero { get; set; }
       
        //FKs
        public int VeterinarioId { get; set; }
        //public Veterinario Veterinario { get; set; }
        
        public Veterinaria Veterinaria{ get; set; }
        public int VeterinariaId { get; set; }
    }
}
