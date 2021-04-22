using Domain.DTOs;
using Domain.IQueries;
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
            var query = db.Query("HistoriasClinicas").
                Join("Registros", "HistoriasClinicas.HistoriaClinicaId", "Registros.HistoriaClinicaId", "=").
                Where("MascotaId", "=", mascotaId);


            var result = query.Get<HistoriaClinica_RegistrosDTO>();

            return result.ToList();
        }
    }
}
