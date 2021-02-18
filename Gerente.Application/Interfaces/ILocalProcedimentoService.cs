using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ILocalProcedimentoService
    {
        Task<IEnumerable<LocalProcedimentoViewModel>> Get();
        Task<LocalProcedimentoViewModel> Get(int? id);
        void Add(LocalProcedimentoViewModel obj);
        void Edit(LocalProcedimentoViewModel obj);
        void Delete(int id);
    }
}