using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessData.Configuration
{
    public class VeterinarioConfiguration
    {
        public VeterinarioConfiguration(EntityTypeBuilder<Veterinario> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.VeterinarioId);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Apellido).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Dni).IsRequired().HasMaxLength(12);
            entityBuilder.Property(x => x.FechaNacimiento).IsRequired();
            entityBuilder.Property(x => x.Sexo).IsRequired().HasMaxLength(1);
            entityBuilder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Domicilio).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Telefono).IsRequired().HasMaxLength(12);
            entityBuilder.Property(x => x.Matricula).IsRequired().HasMaxLength(15);
        }
    }
}
