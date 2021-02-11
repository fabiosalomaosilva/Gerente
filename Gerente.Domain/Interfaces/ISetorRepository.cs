using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ISetorRepository
    {
        Task<IEnumerable<Setor>> Get();
        Task<Setor> Get(int? id);
        void Add(Setor obj, string nomeUsuario);
        void Edit(Setor obj, string nomeUsuario);
        void Delete(Setor obj, string nomeUsuario);
    }
}