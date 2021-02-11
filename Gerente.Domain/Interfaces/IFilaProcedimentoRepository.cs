using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IFilaProcedimentoRepository
    {
        Task<IEnumerable<FilaProcedimento>> Get();
        Task<FilaProcedimento> Get(int? id);
        void Add(FilaProcedimento obj, string nomeUsuario);
        void Edit(FilaProcedimento obj, string nomeUsuario);
        void Delete(FilaProcedimento obj, string nomeUsuario);
    }
}