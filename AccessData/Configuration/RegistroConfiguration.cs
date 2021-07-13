using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AccessData.Configuration
{
    public class RegistroConfiguration
    {
        public RegistroConfiguration(EntityTypeBuilder<Registro> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.RegistroId);
            entityBuilder.Property(x => x.Analisis).IsRequired().HasMaxLength(100);

            var registros = new List<Registro>();
            registros.Add(new Registro { RegistroId = 1, FechaCreacion = DateTime.Parse("2021-7-10"), HistoriaClinicaId = 1, Analisis = "Analisis 1" });
            registros.Add(new Registro { RegistroId = 2, FechaCreacion = DateTime.Parse("2021-7-06"), HistoriaClinicaId = 1, Analisis = "Analisis 2" });
            registros.Add(new Registro { RegistroId = 3, FechaCreacion = DateTime.Parse("2021-7-12"), HistoriaClinicaId = 1, Analisis = "Analisis 3" });
            registros.Add(new Registro { RegistroId = 4, FechaCreacion = DateTime.Parse("2021-7-09"), HistoriaClinicaId = 2, Analisis = "Analisis 1" });
            registros.Add(new Registro { RegistroId = 5, FechaCreacion = DateTime.Parse("2021-7-13"), HistoriaClinicaId = 3, Analisis = "Analisis 1" });
            registros.Add(new Registro { RegistroId = 6, FechaCreacion = DateTime.Parse("2021-7-11"), HistoriaClinicaId = 4, Analisis = "Analisis 1" });
            entityBuilder.HasData(registros);
        }
    }
}