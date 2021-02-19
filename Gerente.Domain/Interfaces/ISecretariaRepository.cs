using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ISecretariaRepository
    {
        Task<IEnumerable<Secretaria>> GetAsync();
        Task<Secretaria> GetAsync(int? id);
        Task<Secretaria> AddAsync(Secretaria obj);
        Task EditAsync(Secretaria obj);
        Task DeleteAsync(Secretaria obj);
    }
}