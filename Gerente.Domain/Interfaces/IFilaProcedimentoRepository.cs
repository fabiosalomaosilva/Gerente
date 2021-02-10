using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IFilaProcedimentoRepository
    {
        Task<IEnumerable<FilaProcedimento>> Get();
        Task<FilaProcedimento> Get(int? id);
        void Add(FilaProcedimento obj);
        void Edit(FilaProcedimento obj);
        void Delete(FilaProcedimento obj);
    }
}