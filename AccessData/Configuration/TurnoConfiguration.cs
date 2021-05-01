using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        }
    }
}
