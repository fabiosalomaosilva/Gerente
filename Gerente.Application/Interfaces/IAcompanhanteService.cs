using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAcompanhanteService
    {
        Task<IEnumerable<AcompanhanteViewModel>> GetAsync();
        Task<AcompanhanteViewModel> GetAsync(int? id);
        Task<AcompanhanteViewModel> AddAsync(AcompanhanteViewModel obj);
        Task EditAsync(AcompanhanteViewModel obj);
        Task DeleteAsync(int id);
    }
}