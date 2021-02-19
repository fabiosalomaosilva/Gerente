using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IContratoRepository
    {
        Task<IEnumerable<Contrato>> GetAsync();
        Task<Contrato> GetAsync(int? id);
        Task<Contrato> AddAsync(Contrato obj);
        Task EditAsync(Contrato obj);
        Task DeleteAsync(Contrato obj);
    }
}