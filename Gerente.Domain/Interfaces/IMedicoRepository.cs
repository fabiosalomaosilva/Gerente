using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> GetAsync();
        Task<Medico> GetAsync(int? id);
        Task<Medico> AddAsync(Medico obj);
        Task EditAsync(Medico obj);
        Task DeleteAsync(Medico obj);
    }
}