using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAgendamentoService
    {
        Task<IEnumerable<AgendamentoViewModel>> Get();
        Task<AgendamentoViewModel> Get(int? id);
        void Add(AgendamentoViewModel obj);
        void Edit(AgendamentoViewModel obj);
        void Delete(int id);
    }
}