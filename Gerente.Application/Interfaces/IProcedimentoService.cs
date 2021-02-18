using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IProcedimentoService
    {
        Task<IEnumerable<ProcedimentoViewModel>> Get();
        Task<ProcedimentoViewModel> Get(int? id);
        void Add(ProcedimentoViewModel obj);
        void Edit(ProcedimentoViewModel obj);
        void Delete(int id);
    }
}