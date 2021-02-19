using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IMunicipioRepository
    {
        Task<IEnumerable<Municipio>> GetAsync();
        Task<Municipio> GetAsync(int? id);
        Task<Municipio> AddAsync(Municipio obj);
        Task EditAsync(Municipio obj);
        Task DeleteAsync(Municipio obj);
    }
}