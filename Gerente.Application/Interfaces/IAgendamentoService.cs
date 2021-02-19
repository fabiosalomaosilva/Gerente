using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAgendamentoService
    {
        Task<IEnumerable<AgendamentoViewModel>> GetAsync();
        Task<AgendamentoViewModel> GetAsync(int? id);
        Task<AgendamentoViewModel> AddAsync(AgendamentoViewModel obj);
        Task EditAsync(AgendamentoViewModel obj);
        Task DeleteAsync(int id);
    }
}