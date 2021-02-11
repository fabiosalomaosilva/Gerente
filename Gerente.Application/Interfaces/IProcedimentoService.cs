using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IProcedimentoService
    {
        Task<IEnumerable<ProcedimentoViewModel>> Get();
        Task<ProcedimentoViewModel> Get(int? id);
        void Add(ProcedimentoViewModel obj, string nomeUsuario);
        void Edit(ProcedimentoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}