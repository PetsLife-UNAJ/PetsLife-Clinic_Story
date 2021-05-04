using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

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

            var veterinarios = new List<Veterinario>();

            veterinarios.Add(new Veterinario { VeterinarioId = 1, Nombre = "Juan", Apellido = "Diaz", Dni = "42132121", FechaNacimiento = "14-9-1990", Sexo = "m", Email = "juandiaz@gmail.com", Domicilio = "Calle 21 231", Telefono = "42113212", Matricula = "ADS213", ConsultorioId = 1 });
            veterinarios.Add(new Veterinario { VeterinarioId = 2, Nombre = "Martina", Apellido = "Perez", Dni = "321321321", FechaNacimiento = "24-3-1958", Sexo = "f", Email = "juandiaz@gmail.com", Domicilio = "Calle 132 7654", Telefono = "4232136", Matricula = "XSD213", ConsultorioId = 2 });

            entityBuilder.HasData(veterinarios);
        }
    }
}