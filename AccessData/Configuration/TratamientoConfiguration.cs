using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Configuration
{
    public class TratamientoConfiguration
    {
        public TratamientoConfiguration(EntityTypeBuilder<Tratamiento> entityBuilder)
        {
            var tratamientos = new List<Tratamiento>();
            tratamientos.Add(new Tratamiento { TratamientoId = 1, Descripcion = "Tratamiento 1", RegistroId = 1 });
            tratamientos.Add(new Tratamiento { TratamientoId = 2, Descripcion = "Tratamiento 2", RegistroId = 2 });
            tratamientos.Add(new Tratamiento { TratamientoId = 3, Descripcion = "Tratamiento 3", RegistroId = 3 });
            tratamientos.Add(new Tratamiento { TratamientoId = 4, Descripcion = "Tratamiento 1", RegistroId = 4 });
            tratamientos.Add(new Tratamiento { TratamientoId = 5, Descripcion = "Tratamiento 1", RegistroId = 5 });
            tratamientos.Add(new Tratamiento { TratamientoId = 6, Descripcion = "Tratamiento 1", RegistroId = 6 });

            entityBuilder.HasData(tratamientos);
        }
    }
}