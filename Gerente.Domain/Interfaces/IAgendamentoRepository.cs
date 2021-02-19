using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IAgendamentoRepository
    {
        Task<IEnumerable<Agendamento>> GetAsync();
        Task<Agendamento> GetAsync(int? id);
        Task<Agendamento> AddAsync(Agendamento obj);
        Task EditAsync(Agendamento obj);
        Task DeleteAsync(Agendamento obj);
    }
}