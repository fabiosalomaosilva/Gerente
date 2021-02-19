using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> GetAsync();
        Task<Pessoa> GetAsync(int? id);
        Task<Pessoa> AddAsync(Pessoa obj);
        Task EditAsync(Pessoa obj);
        Task DeleteAsync(Pessoa obj);
    }
}