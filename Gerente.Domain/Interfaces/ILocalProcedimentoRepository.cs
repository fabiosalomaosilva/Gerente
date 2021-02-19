using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ILocalProcedimentoRepository
    {
        Task<IEnumerable<LocalProcedimento>> GetAsync();
        Task<LocalProcedimento> GetAsync(int? id);
        Task<LocalProcedimento> AddAsync(LocalProcedimento obj);
        Task EditAsync(LocalProcedimento obj);
        Task DeleteAsync(LocalProcedimento obj);
    }
}