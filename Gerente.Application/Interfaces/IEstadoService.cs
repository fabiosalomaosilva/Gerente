using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IEstadoService
    {
        Task<IEnumerable<EstadoViewModel>> GetAsync();
        Task<EstadoViewModel> GetAsync(int? id);
        Task<EstadoViewModel> AddAsync(EstadoViewModel obj);
        Task EditAsync(EstadoViewModel obj);
        Task DeleteAsync(int id);
    }
}