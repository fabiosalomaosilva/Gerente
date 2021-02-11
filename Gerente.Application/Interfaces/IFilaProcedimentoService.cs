using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IFilaProcedimentoService
    {
        Task<IEnumerable<FilaProcedimentoViewModel>> Get();
        Task<FilaProcedimentoViewModel> Get(int? id);
        void Add(FilaProcedimentoViewModel obj, string nomeUsuario);
        void Edit(FilaProcedimentoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}