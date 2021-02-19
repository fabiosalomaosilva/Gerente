using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ITelefoneRepository
    {
        Task<IEnumerable<Telefone>> GetAsync();
        Task<Telefone> GetAsync(int? id);
        Task<Telefone> AddAsync(Telefone obj);
        Task EditAsync(Telefone obj);
        Task DeleteAsync(Telefone obj);
    }
}