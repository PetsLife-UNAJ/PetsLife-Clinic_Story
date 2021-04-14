using Domain.ICommands;
using Domain.IQueries;
using Domain.Models;

namespace Application.Services
{
    public interface IRegistroService
    {
        Registro GetRegistroByHistoriaClinicaId(int id);
    }

    public class RegistroService:IRegistroService
    {
        private readonly IGenericRepository _repository;
        private readonly IRegistroQueries _query;

        public RegistroService(IGenericRepository repository, IRegistroQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public Registro GetRegistroByHistoriaClinicaId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
