using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IAgendamentoRepository
    {
        Task<IEnumerable<Agendamento>> Get();
        Task<Agendamento> Get(int? id);
        void Add(Agendamento obj);
        void Edit(Agendamento obj);
        void Delete(Agendamento obj);
    }
}