using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> Get();
        Task<Pessoa> Get(int? id);
        void Add(Pessoa obj);
        void Edit(Pessoa obj);
        void Delete(Pessoa obj);
    }
}