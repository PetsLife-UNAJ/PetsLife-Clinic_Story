using Domain.DTOs;
using System.Collections.Generic;

namespace AccessData.Queries.Repository
{
    public interface IClienteQueries
    {
        GetClienteDTO GetClienteById(int id);
        List<GetClienteDTO> GetAll();
    }
}
