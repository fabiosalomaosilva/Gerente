using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IEspecialidadeRepository
    {
        Task<IEnumerable<Especialidade>> Get();
        Task<Especialidade> Get(int? id);
        void Add(Especialidade obj, string nomeUsuario);
        void Edit(Especialidade obj, string nomeUsuario);
        void Delete(Especialidade obj, string nomeUsuario);
    }
}