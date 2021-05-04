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

            var veterinaria = new Veterinaria { VeterinariaId = 1, Nombre = "Pet's Life", Direccion = "Av. San martin 382", Telefono = "4256-2351" };

            entityBuilder.HasData(veterinaria);
        }
    }
}