using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ITelefoneRepository
    {
        Task<IEnumerable<Telefone>> Get();
        Task<Telefone> Get(int? id);
        void Add(Telefone obj);
        void Edit(Telefone obj);
        void Delete(Telefone obj);
    }
}