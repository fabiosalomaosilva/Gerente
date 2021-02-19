using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteViewModel>> GetAsync();
        Task<PacienteViewModel> GetAsync(int? id);
        Task<PacienteViewModel> AddAsync(PacienteViewModel obj);
        Task EditAsync(PacienteViewModel obj);
        Task DeleteAsync(int id);
    }
}