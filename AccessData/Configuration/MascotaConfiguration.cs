using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class MascotaConfiguration
    {
        public MascotaConfiguration(EntityTypeBuilder<Mascota> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.MascotaId);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Edad).IsRequired().HasMaxLength(2);
            entityBuilder.Property(x => x.Peso).IsRequired().HasMaxLength(3);
        }
    }
}
