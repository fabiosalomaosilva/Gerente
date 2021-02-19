using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IEstadoRepository
    {
        Task<ListData> GetAsync(PaginationDTO pagination, string name);
        Task<Estado> GetAsync(int? id);
        Task<Estado> AddAsync(Estado obj);
        Task EditAsync(Estado obj);
        Task DeleteAsync(Estado obj);
    }
}