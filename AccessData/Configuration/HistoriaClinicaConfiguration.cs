using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace AccessData.Configuration
{
    public class HistoriaClinicaConfiguration
    {
        public HistoriaClinicaConfiguration(EntityTypeBuilder<HistoriaClinica> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.HistoriaClinicaId);

            var historias = new List<HistoriaClinica>();

            historias.Add(new HistoriaClinica { HistoriaClinicaId = 1, MascotaId = 1 });
            historias.Add(new HistoriaClinica { HistoriaClinicaId = 2, MascotaId = 2 });
            historias.Add(new HistoriaClinica { HistoriaClinicaId = 3, MascotaId = 3 });
            historias.Add(new HistoriaClinica { HistoriaClinicaId = 4, MascotaId = 4 });
            entityBuilder.HasData(historias);
        }
    }
}