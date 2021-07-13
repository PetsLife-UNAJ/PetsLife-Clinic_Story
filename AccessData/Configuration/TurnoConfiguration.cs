using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace AccessData.Configuration
{
    public class TurnoConfiguration
    {
        public TurnoConfiguration(EntityTypeBuilder<Turno> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.TurnoId);
            entityBuilder.Property(x => x.Fecha).IsRequired();
            entityBuilder.Property(x => x.HoraInicio).IsRequired();
            entityBuilder.Property(x => x.Horafin).IsRequired();

            var turnos = new List<Turno>();

            turnos.Add(new Turno { TurnoId = 1, Fecha = DateTime.Parse("2021-7-15"), HoraInicio = Convert.ToDateTime("09:00"), Horafin = Convert.ToDateTime("09:30"), MascotaId = 1, VeterinarioId = 2 });
            turnos.Add(new Turno { TurnoId = 2, Fecha = DateTime.Parse("2021-7-15"), HoraInicio = Convert.ToDateTime("10:00"), Horafin = Convert.ToDateTime("10:30"), MascotaId = 2, VeterinarioId = 3 });
            turnos.Add(new Turno { TurnoId = 3, Fecha = DateTime.Parse("2021-7-15"), HoraInicio = Convert.ToDateTime("17:30"), Horafin = Convert.ToDateTime("18:00"), MascotaId = 1, VeterinarioId = 2 });
            entityBuilder.HasData(turnos);
        }
    }
}