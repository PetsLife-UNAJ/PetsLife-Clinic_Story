using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class HistoriaClinicaConfiguration
    {
        public HistoriaClinicaConfiguration(EntityTypeBuilder<HistoriaClinica> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.HistoriaClinicaId);
        }
    }
}
