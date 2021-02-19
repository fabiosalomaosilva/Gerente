using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IMunicipioService
    {
        Task<IEnumerable<MunicipioViewModel>> GetAsync();
        Task<MunicipioViewModel> GetAsync(int? id);
        Task<MunicipioViewModel> AddAsync(MunicipioViewModel obj);
        Task EditAsync(MunicipioViewModel obj);
        Task DeleteAsync(int id);
    }
}