using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IFilaProcedimentoRepository
    {
        Task<IEnumerable<FilaProcedimento>> GetAsync();
        Task<FilaProcedimento> GetAsync(int? id);
        Task<FilaProcedimento> AddAsync(FilaProcedimento obj);
        Task EditAsync(FilaProcedimento obj);
        Task DeleteAsync(FilaProcedimento obj);
    }
}