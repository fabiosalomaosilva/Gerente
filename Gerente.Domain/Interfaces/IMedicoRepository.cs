using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> Get();
        Task<Medico> Get(int? id);
        void Add(Medico obj);
        void Edit(Medico obj);
        void Delete(Medico obj);
    }
}