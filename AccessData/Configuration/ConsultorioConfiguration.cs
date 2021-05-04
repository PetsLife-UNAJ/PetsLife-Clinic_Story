using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class ConsultorioConfiguration
    {
        public ConsultorioConfiguration(EntityTypeBuilder<Consultorio> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ConsultorioId);
            entityBuilder.Property(x => x.Numero).IsRequired().HasMaxLength(2);
        }
    }
}
