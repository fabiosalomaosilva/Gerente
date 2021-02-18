using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteViewModel>> Get();
        Task<PacienteViewModel> Get(int? id);
        void Add(PacienteViewModel obj);
        void Edit(PacienteViewModel obj);
        void Delete(int id);
    }
}