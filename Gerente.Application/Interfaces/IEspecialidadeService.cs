using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IEspecialidadeService
    {
        Task<IEnumerable<EspecialidadeViewModel>> GetAsync();
        Task<EspecialidadeViewModel> GetAsync(int? id);
        Task<EspecialidadeViewModel> AddAsync(EspecialidadeViewModel obj);
        Task EditAsync(EspecialidadeViewModel obj);
        Task DeleteAsync(int id);
    }
}