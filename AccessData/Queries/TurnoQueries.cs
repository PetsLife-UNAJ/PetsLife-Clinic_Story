using AccessData.Queries.Repository;
using Domain.DTOs;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AccessData.Queries
{
    public class TurnoQueries : ITurnoQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public TurnoQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<ResponseTurno> GetAllByFecha(DateTime? fecha)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            if (fecha != null)
            {
                var query = db.Query("Turno").WhereDate("Fecha", "=", fecha).Get<ResponseTurno>().ToList();
                return query;
            }
            else
            {
                var query = db.Query("Turno").Get<ResponseTurno>().ToList();
                return query;
            }
        }

        public List<int> ListVeterinariosDisponibles(DateTime fecha, DateTime horaInicio)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var ListVeterinariosId = db.Query("Veterinario").Select("VeterinarioId").Get<int>().ToList();

            string inicio = horaInicio.Hour + ":" + horaInicio.Minute;

            var ListVeterinariosIdNoDisponibles = db.Query("Turno").Select("VeterinarioId").WhereDate("Fecha", "=", fecha)
                .WhereTime("HoraInicio", "=", inicio).Get<int>().ToList();

            foreach (var item in ListVeterinariosIdNoDisponibles)
            {
                if (ListVeterinariosId.Contains(item))
                {
                    ListVeterinariosId.Remove(item);
                }
            }

            return ListVeterinariosId;
        }
    }
}