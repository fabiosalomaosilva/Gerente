using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ISecretariaRepository
    {
        Task<IEnumerable<Secretaria>> Get();
        Task<Secretaria> Get(int? id);
        void Add(Secretaria obj);
        void Edit(Secretaria obj);
        void Delete(Secretaria obj);
    }
}