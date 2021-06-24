using AccessData.Queries.Repository;
using Domain.DTOs;
using Domain.Models;
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

        public List<ResponseTurnoData> GetAllByFecha(DateTime? fecha)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            if (fecha != null)
            {
                var query = db.Query("Turno").Select("*").Select("Veterinario.Nombre as VeterinarioNombre", "Veterinario.Apellido as VeterinarioApellido",
                    "Consultorio.Numero as ConsultorioNumero", "Mascota.Nombre as MascotaNombre", "Cliente.Nombre as ClienteNombre", "Cliente.Apellido as ClienteApellido", "Cliente.Telefono as ClienteTelefono")
                    .Join("Veterinario", "Veterinario.VeterinarioId", "Turno.VeterinarioId")
                    .Join("Consultorio", "Consultorio.ConsultorioId", "Veterinario.ConsultorioId")
                    .Join("Mascota", "Mascota.MascotaId", "Turno.MascotaId")
                    .Join("Cliente", "Cliente.ClienteId", "Mascota.ClienteId")

                    .WhereDate("Fecha", "=", fecha).Get<ResponseTurnoData>().ToList();
                return query;
            }
            else
            {
                var query = db.Query("Turno")
                    .Select("*").Select("Veterinario.Nombre as VeterinarioNombre", "Veterinario.Apellido as VeterinarioApellido",
                    "Consultorio.Numero as ConsultorioNumero", "Mascota.Nombre as MascotaNombre", "Cliente.Nombre as ClienteNombre", "Cliente.Apellido as ClienteApellido", "Cliente.Telefono as ClienteTelefono")
                     .Join("Veterinario", "Veterinario.VeterinarioId", "Turno.VeterinarioId")
                    .Join("Consultorio", "Consultorio.ConsultorioId", "Veterinario.ConsultorioId")
                    .Join("Mascota", "Mascota.MascotaId", "Turno.MascotaId")
                    .Join("Cliente", "Cliente.ClienteId", "Mascota.ClienteId")
                    .Get<ResponseTurnoData>().ToList();
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

        public List<ResponseTurnoData> GetByVeterinarioId(int veterinarioId, DateTime fecha)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var query = db.Query("Turno").Select("*").Select("Veterinario.Nombre as VeterinarioNombre", "Veterinario.Apellido as VeterinarioApellido",
                   "Consultorio.Numero as ConsultorioNumero", "Mascota.Nombre as MascotaNombre", "Cliente.Nombre as ClienteNombre", "Cliente.Apellido as ClienteApellido", "Cliente.Telefono as ClienteTelefono")
                   .Join("Veterinario", "Veterinario.VeterinarioId", "Turno.VeterinarioId")
                   .Join("Consultorio", "Consultorio.ConsultorioId", "Veterinario.ConsultorioId")
                   .Join("Mascota", "Mascota.MascotaId", "Turno.MascotaId")
                   .Join("Cliente", "Cliente.ClienteId", "Mascota.ClienteId")
                   .WhereDate("Fecha", "=", fecha)
                   .Where("Veterinario.VeterinarioId", "=", veterinarioId)
                   .Get<ResponseTurnoData>().ToList();

            return query;
        }

        public Turno getTurnoById(int turnoId)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var query = db.Query("Turno").Select("*").Where("TurnoId", "=", turnoId).Get<Turno>().FirstOrDefault();

            return query;
        }
    }
}