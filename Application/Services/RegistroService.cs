using AccessData.Commands;
using Domain.DTOs;
using Domain.Models;

namespace Application.Services
{
    public interface IRegistroService
    {
        ResponseRegistro CreateRegistro(RegistroDTO registro);
    }

    public class RegistroService : IRegistroService
    {
        private readonly IGenericRepository _repository;

        public RegistroService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public ResponseRegistro CreateRegistro(RegistroDTO registro)
        {
            Registro entity = new Registro
            {
                HistoriaClinicaId = registro.HistoriaClinicaId,
                Analisis = registro.Analisis
            };

            _repository.Add<Registro>(entity);

            return new ResponseRegistro
            {
                RegistroId = entity.RegistroId,
                Analisis = entity.Analisis,
                HistoriaClinicaId = entity.HistoriaClinicaId
            };
        }


    }
}
