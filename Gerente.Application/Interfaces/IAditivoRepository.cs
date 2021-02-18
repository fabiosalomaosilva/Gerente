using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAditivoService
    {
        Task<IEnumerable<AditivoViewModel>> GetAsync();
        Task<AditivoViewModel> GetAsync(int? id);
        Task<AditivoViewModel> AddAsync(AditivoViewModel obj);
        Task EditAsync(AditivoViewModel obj);
        Task DeleteAsync(int id);
    }
}
