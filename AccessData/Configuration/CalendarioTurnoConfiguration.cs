using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class CalendarioTurnoConfiguration
    {
        public CalendarioTurnoConfiguration(EntityTypeBuilder<CalendarioTurno> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.VeterinarioId);
            entityBuilder.Property(x => x.Dia).IsRequired();
            entityBuilder.Property(x => x.HoraInicio).IsRequired();
            entityBuilder.Property(x => x.Horafin).IsRequired();
        }
    }
}
