using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IEspecialidadeRepository
    {
        Task<IEnumerable<Especialidade>> GetAsync();
        Task<Especialidade> GetAsync(int? id);
        Task<Especialidade> AddAsync(Especialidade obj);
        Task EditAsync(Especialidade obj);
        Task DeleteAsync(Especialidade obj);
    }
}