using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ITelefoneService
    {
        Task<IEnumerable<TelefoneViewModel>> GetAsync();
        Task<TelefoneViewModel> GetAsync(int? id);
        Task<TelefoneViewModel> AddAsync(TelefoneViewModel obj);
        Task EditAsync(TelefoneViewModel obj);
        Task DeleteAsync(int id);
    }
}