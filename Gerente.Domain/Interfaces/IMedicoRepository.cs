using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> Get();
        Task<Medico> Get(int? id);
        void Add(Medico obj, string nomeUsuario);
        void Edit(Medico obj, string nomeUsuario);
        void Delete(Medico obj, string nomeUsuario);
    }
}