using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAgendamentoService
    {
        Task<IEnumerable<AgendamentoViewModel>> Get();
        Task<AgendamentoViewModel> Get(int? id);
        void Add(AgendamentoViewModel obj, string nomeUsuario);
        void Edit(AgendamentoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}