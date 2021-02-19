using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ISetorService
    {
        Task<IEnumerable<SetorViewModel>> GetAsync();
        Task<SetorViewModel> GetAsync(int? id);
        Task<SetorViewModel> AddAsync(SetorViewModel obj);
        Task EditAsync(SetorViewModel obj);
        Task DeleteAsync(int id);
    }
}