using Domain.IQueries;
using Domain.Models;
using SqlKata.Compilers;
using System;
using System.Data;

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

        public HistoriaClinica GetHistoriaClinicaByMascotaId(int mascotaId)
        {
            throw new NotImplementedException();
        }
    }
}
