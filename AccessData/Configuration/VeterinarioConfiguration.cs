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

            veterinarios.Add(new Veterinario { VeterinarioId = 100, Nombre = "Juan", Apellido = "Diaz", Dni = "42132121", FechaNacimiento = "14-9-1990", Sexo = "m", Email = "juandiaz@gmail.com", Domicilio = "Calle 21 231", Telefono = "42113212", Matricula = "ADS213", ConsultorioId = 1 });
            veterinarios.Add(new Veterinario { VeterinarioId = 101, Nombre = "Martina", Apellido = "Perez", Dni = "321321321", FechaNacimiento = "28-3-1958", Sexo = "f", Email = "juandiaz@gmail.com", Domicilio = "Calle 132 7654", Telefono = "4232136", Matricula = "XSD213", ConsultorioId = 2 });
            veterinarios.Add(new Veterinario { VeterinarioId = 102, Nombre = "Claudio", Apellido = "Martinez", Dni = "25432567", FechaNacimiento = "12-1-1974", Sexo = "m", Email = "juandiaz@gmail.com", Domicilio = "Calle 252 532", Telefono = "42562132", Matricula = "TDQ231", ConsultorioId = 3 });
            veterinarios.Add(new Veterinario { VeterinarioId = 103, Nombre = "Silvia", Apellido = "Gomez", Dni = "34568245", FechaNacimiento = "24-5-1967", Sexo = "f", Email = "juandiaz@gmail.com", Domicilio = "Calle 689 232", Telefono = "42517831", Matricula = "HYC261", ConsultorioId = 4 });
            veterinarios.Add(new Veterinario { VeterinarioId = 104, Nombre = "Clarisa", Apellido = "Rosales", Dni = "40568326", FechaNacimiento = "22-3-1969", Sexo = "f", Email = "juandiaz@gmail.com", Domicilio = "Calle 998 6343", Telefono = "53214562", Matricula = "JLP753", ConsultorioId = 5 });

            entityBuilder.HasData(veterinarios);
        }
    }
}