using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace AccessData.Configuration
{
    public class ClienteConfiguration
    {
        public ClienteConfiguration(EntityTypeBuilder<Cliente> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ClienteId);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Apellido).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Dni).IsRequired().HasMaxLength(8);
            entityBuilder.Property(x => x.Direccion).IsRequired().HasMaxLength(50);
            entityBuilder.Property(x => x.Telefono).IsRequired().HasMaxLength(12);

            var cliente = new List<Cliente>();

            cliente.Add(new Cliente { ClienteId = 1, Nombre = "Jose", Apellido = "Bravo", Email = "bravo.jose.luis18@gmail.com", Dni = "39876453", Direccion = "Calle 9 N2946", Telefono = "1136756432" });
            cliente.Add(new Cliente { ClienteId = 2, Nombre = "Claudio", Apellido = "Damico", Email = "claudio.damico@gmail.com", Dni = "12383764", Direccion = "Moreno 322", Telefono = "1123455877" });
            cliente.Add(new Cliente { ClienteId = 3, Nombre = "Julian", Apellido = "Nuzzo", Email = "julian.nuzzo@gmail.com", Dni = "39987666", Direccion = "Lavelle 987", Telefono = "1123982376" });

            entityBuilder.HasData(cliente);
        }
    }
}