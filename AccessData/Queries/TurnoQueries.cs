using AccessData.Queries.Repository;
using Domain.DTOs;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<ResponseTurno> GetAllByFecha(string fecha)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);
            var turnos = db.Query("Turno").Select("Fecha", "HoraInicio", "Horafin","MascotaId","CalendarioTurnoId").Where("Fecha","=",fecha).Get<ResponseTurno>().ToList();

            

            return new List<ResponseTurno>(turnos);
        }

        
        
    }
}
