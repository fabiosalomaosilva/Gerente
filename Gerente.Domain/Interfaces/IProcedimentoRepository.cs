using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IProcedimentoRepository
    {
        Task<IEnumerable<Procedimento>> GetAsync();
        Task<Procedimento> GetAsync(int? id);
        Task<Procedimento> AddAsync(Procedimento obj);
        Task EditAsync(Procedimento obj);
        Task DeleteAsync(Procedimento obj);
    }
}