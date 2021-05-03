﻿using AccessData.Queries.Repository;
using Domain.DTOs;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AccessData.Queries
{
    public class ClienteQueries : IClienteQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public ClienteQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<GetClienteDTO> GetAll()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var cliente = db.Query("Cliente").Select("ClienteId","Nombre", "Apellido", "Email", "Dni", "Direccion", "Telefono").Get<GetClienteDTO>().ToList();
           
            foreach (var item in cliente)
            {
                item.Mascotas = db.Query("Mascota").Select("Nombre", "Edad", "Peso").Where("ClienteId", "=", item.ClienteId).Get<MascotaDTO>().ToList();
            }
            
            return new List<GetClienteDTO>(cliente);
        }

        public GetClienteDTO GetClienteById(int id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var cliente = db.Query("Cliente").Where("ClienteId", "=", id).FirstOrDefault<ClienteDTO>(); ;
            var mascotas = db.Query("Mascota").Select("Nombre", "Edad", "Peso")
                .Where("ClienteId", "=", id).Get<MascotaDTO>().ToList();

            return new GetClienteDTO
            {
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                Dni = cliente.Email,
                Direccion = cliente.Direccion,
                Telefono = cliente.Telefono,
                Mascotas = mascotas
            };
        }
    }
}
