using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ITelefoneRepository
    {
        Task<IEnumerable<Telefone>> Get();
        Task<Telefone> Get(int? id);
        void Add(Telefone obj, string nomeUsuario);
        void Edit(Telefone obj, string nomeUsuario);
        void Delete(Telefone obj, string nomeUsuario);
    }
}