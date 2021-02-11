using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IEstadoRepository
    {
        Task<IEnumerable<Estado>> Get();
        Task<Estado> Get(int? id);
        void Add(Estado obj, string nomeUsuario);
        void Edit(Estado obj, string nomeUsuario);
        void Delete(Estado obj, string nomeUsuario);
    }
}