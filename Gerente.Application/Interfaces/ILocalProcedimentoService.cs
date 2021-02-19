using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ILocalProcedimentoService
    {
        Task<IEnumerable<LocalProcedimentoViewModel>> GetAsync();
        Task<LocalProcedimentoViewModel> GetAsync(int? id);
        Task<LocalProcedimentoViewModel> AddAsync(LocalProcedimentoViewModel obj);
        Task EditAsync(LocalProcedimentoViewModel obj);
        Task DeleteAsync(int id);
    }
}