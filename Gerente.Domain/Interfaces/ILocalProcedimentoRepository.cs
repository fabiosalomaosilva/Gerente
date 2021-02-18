using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ILocalProcedimentoRepository
    {
        Task<IEnumerable<LocalProcedimento>> Get();
        Task<LocalProcedimento> Get(int? id);
        void Add(LocalProcedimento obj);
        void Edit(LocalProcedimento obj);
        void Delete(LocalProcedimento obj);
    }
}