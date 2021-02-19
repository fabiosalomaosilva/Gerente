using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<IEnumerable<Documento>> GetAsync();
        Task<Documento> GetAsync(int? id);
        Task<Documento> AddAsync(Documento obj);
        Task EditAsync(Documento obj);
        Task DeleteAsync(Documento obj);
    }
}