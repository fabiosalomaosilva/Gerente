using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ILocalProcedimentoService
    {
        Task<IEnumerable<LocalProcedimentoViewModel>> Get();
        Task<LocalProcedimentoViewModel> Get(int? id);
        void Add(LocalProcedimentoViewModel obj, string nomeUsuario);
        void Edit(LocalProcedimentoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}