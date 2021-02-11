using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<PacienteViewModel>> Get();
        Task<PacienteViewModel> Get(int? id);
        void Add(PacienteViewModel obj, string nomeUsuario);
        void Edit(PacienteViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}