using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IFilaProcedimentoService
    {
        Task<IEnumerable<FilaProcedimentoViewModel>> GetAsync();
        Task<FilaProcedimentoViewModel> GetAsync(int? id);
        Task<FilaProcedimentoViewModel> AddAsync(FilaProcedimentoViewModel obj);
        Task EditAsync(FilaProcedimentoViewModel obj);
        Task DeleteAsync(int id);
    }
}