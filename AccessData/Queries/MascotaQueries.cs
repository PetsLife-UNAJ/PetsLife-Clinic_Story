using AccessData.Queries.Repository;
using SqlKata.Compilers;
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
    }
}