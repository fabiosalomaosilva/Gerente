using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ICargoRepository
    {
        Task<IEnumerable<Cargo>> GetAsync();
        Task<Cargo> GetAsync(int? id);
        Task<Cargo> AddAsync(Cargo obj);
        Task EditAsync(Cargo obj);
        Task DeleteAsync(Cargo obj);
    }
}