using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ICargoService
    {
        Task<IEnumerable<CargoViewModel>> GetAsync();
        Task<CargoViewModel> GetAsync(int? id);
        Task<CargoViewModel> AddAsync(CargoViewModel obj);
        Task EditAsync(CargoViewModel obj);
        Task DeleteAsync(int id);
    }
}