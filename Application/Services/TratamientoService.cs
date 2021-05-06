using AccessData.Commands;
using Domain.DTOs;
using Domain.Entities;

namespace Application.Services
{
    public interface ITratamientoService
    {
        public ResponseTratamiento CreateTratamiento(TratamientoDTO tratamientoDto);
    }

    public class TratamientoService : ITratamientoService
    {
        private readonly IGenericRepository _repository;
        public TratamientoService(IGenericRepository repository)
        {
            _repository = repository;
        }

        public ResponseTratamiento CreateTratamiento(TratamientoDTO tratamientoDto)
        {
            Tratamiento tratamiento = new Tratamiento
            {
                Descripcion = tratamientoDto.Descripcion,
                RegistroId = tratamientoDto.RegistroId
            };

            _repository.Add<Tratamiento>(tratamiento);
            _repository.SaveChanges();

            return new ResponseTratamiento
            {
                TratamientoId = tratamiento.TratamientoId,
                Descripcion = tratamiento.Descripcion,
                RegistroId = tratamiento.RegistroId
            };
        }
    }
}