using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ISetorRepository
    {
        Task<IEnumerable<Setor>> GetAsync();
        Task<Setor> GetAsync(int? id);
        Task<Setor> AddAsync(Setor obj);
        Task EditAsync(Setor obj);
        Task DeleteAsync(Setor obj);
    }
}