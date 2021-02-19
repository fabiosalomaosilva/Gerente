using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IProcedimentoService
    {
        Task<IEnumerable<ProcedimentoViewModel>> GetAsync();
        Task<ProcedimentoViewModel> GetAsync(int? id);
        Task<ProcedimentoViewModel> AddAsync(ProcedimentoViewModel obj);
        Task EditAsync(ProcedimentoViewModel obj);
        Task DeleteAsync(int id);
    }
}