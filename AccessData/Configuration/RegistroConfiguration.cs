using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class RegistroConfiguration
    {
        public RegistroConfiguration(EntityTypeBuilder<Registro> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.RegistroId);
            entityBuilder.Property(x => x.Analisis).IsRequired().HasMaxLength(100);
        }
    }
}
