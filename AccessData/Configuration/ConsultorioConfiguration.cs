using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace AccessData.Configuration
{
    public class ConsultorioConfiguration
    {
        public ConsultorioConfiguration(EntityTypeBuilder<Consultorio> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ConsultorioId);
            entityBuilder.Property(x => x.Numero).IsRequired().HasMaxLength(2);

            var consultorios = new List<Consultorio>();

            consultorios.Add(new Consultorio { ConsultorioId = 1, Numero = 100, VeterinariaId = 1 });
            consultorios.Add(new Consultorio { ConsultorioId = 2, Numero = 101, VeterinariaId = 1 });
            consultorios.Add(new Consultorio { ConsultorioId = 3, Numero = 200, VeterinariaId = 1 });
            consultorios.Add(new Consultorio { ConsultorioId = 4, Numero = 201, VeterinariaId = 1 });
            consultorios.Add(new Consultorio { ConsultorioId = 5, Numero = 202, VeterinariaId = 1 });

            entityBuilder.HasData(consultorios);
        }
    }
}