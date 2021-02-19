using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IMedicoService
    {
        Task<IEnumerable<MedicoViewModel>> GetAsync();
        Task<MedicoViewModel> GetAsync(int? id);
        Task<MedicoViewModel> AddAsync(MedicoViewModel obj);
        Task EditAsync(MedicoViewModel obj);
        Task DeleteAsync(int id);
    }
}