using AccessData.Commands;
using Domain.DTOs;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AccessData.Queries
{
    public class HistoriaClinicaQueries : IHistoriaClinicaQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public HistoriaClinicaQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<HistoriaClinica_RegistrosDTO> GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var query = db.Query("HistoriasClinicas")
                .Select("*").Select("Descripcion as Tratamiento").
                Join("Registros", "HistoriasClinicas.HistoriaClinicaId", "Registros.HistoriaClinicaId")
                .Join("Tratamiento", "Registros.RegistroId", "Tratamiento.RegistroId").
                Where("HistoriasClinicas.MascotaId", "=", mascotaId);

            var result = query.Get<HistoriaClinica_RegistrosDTO>().ToList();

            if (result.Count == 0)
            {
                result = db.Query("HistoriasClinicas")
                 .Select("*")
                 .Where("HistoriasClinicas.MascotaId", "=", mascotaId).Get<HistoriaClinica_RegistrosDTO>().ToList();
            }

            return result;
        }
    }
}