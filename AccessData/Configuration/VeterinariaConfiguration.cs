using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class VeterinariaConfiguration
    {
        public VeterinariaConfiguration(EntityTypeBuilder<Veterinaria> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.VeterinariaId);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(20);
            entityBuilder.Property(x => x.Direccion).IsRequired().HasMaxLength(20);
            entityBuilder.Property(x => x.Telefono).IsRequired().HasMaxLength(20);
        }
    }
}
