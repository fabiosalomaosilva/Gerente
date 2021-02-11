using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IProcedimentoRepository
    {
        Task<IEnumerable<Procedimento>> Get();
        Task<Procedimento> Get(int? id);
        void Add(Procedimento obj, string nomeUsuario);
        void Edit(Procedimento obj, string nomeUsuario);
        void Delete(Procedimento obj, string nomeUsuario);
    }
}