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

            cliente.Add(new Cliente { ClienteId = 5, Nombre = "Jose", Apellido = "Bravo", Email = "cliente@gmail.com", Dni = "39876453", Direccion = "Calle 9 N2946", Telefono = "1136756432" });

            entityBuilder.HasData(cliente);
        }
    }
}