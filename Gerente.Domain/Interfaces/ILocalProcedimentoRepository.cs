using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ILocalProcedimentoRepository
    {
        Task<IEnumerable<LocalProcedimento>> Get();
        Task<LocalProcedimento> Get(int? id);
        void Add(LocalProcedimento obj, string nomeUsuario);
        void Edit(LocalProcedimento obj, string nomeUsuario);
        void Delete(LocalProcedimento obj, string nomeUsuario);
    }
}