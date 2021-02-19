using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IContratoService
    {
        Task<IEnumerable<ContratoViewModel>> GetAsync();
        Task<ContratoViewModel> GetAsync(int? id);
        Task<ContratoViewModel> AddAsync(ContratoViewModel obj);
        Task EditAsync(ContratoViewModel obj);
        Task DeleteAsync(int id);
    }
}