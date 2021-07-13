using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace AccessData.Configuration
{
    public class MascotaConfiguration
    {
        public MascotaConfiguration(EntityTypeBuilder<Mascota> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.MascotaId);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Edad).IsRequired().HasMaxLength(2);
            entityBuilder.Property(x => x.Peso).IsRequired().HasMaxLength(2);

            var mascotas = new List<Mascota>();

            mascotas.Add(new Mascota { MascotaId = 1, Nombre = "Morena", ClienteId = 5, Peso = 3, Edad = 5 });
            mascotas.Add(new Mascota { MascotaId = 2, Nombre = "Tomas", ClienteId = 5, Peso = 10, Edad = 9 });
            mascotas.Add(new Mascota { MascotaId = 3, Nombre = "Firulais", ClienteId = 5, Peso = 2, Edad = 1 });
            mascotas.Add(new Mascota { MascotaId = 4, Nombre = "Lola", ClienteId = 6, Peso = 21, Edad = 12 });

            entityBuilder.HasData(mascotas);
        }
    }
}