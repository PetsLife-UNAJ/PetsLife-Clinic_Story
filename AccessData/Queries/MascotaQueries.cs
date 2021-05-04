using AccessData.Queries.Repository;
using Domain.DTOs;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;

namespace AccessData.Queries
{
    public class MascotaQueries : IMascotaQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public MascotaQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public ResponseMascota GetMascotaById(int Id)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var query = db.Query("Mascota")
                .Where("Mascota.MascotaId", "=", Id).FirstOrDefault<ResponseMascota>();

            return query;
        }
    }
}