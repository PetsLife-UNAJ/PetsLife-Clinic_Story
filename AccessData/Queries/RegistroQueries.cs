using Domain.IQueries;
using Domain.Models;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Queries
{
    public class RegistroQueries:IRegistroQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public RegistroQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public Registro GetRegistrosByHistoriaClinicaId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
