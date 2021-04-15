using Domain.ICommands;
using Domain.IQueries;
using Domain.Models;

namespace Application.Services
{
    public interface IRegistroService
    {
       
    }

    public class RegistroService:IRegistroService
    {
        private readonly IGenericRepository _repository;

        public RegistroService(IGenericRepository repository)
        {
            _repository = repository;
        }

      
    }
}
