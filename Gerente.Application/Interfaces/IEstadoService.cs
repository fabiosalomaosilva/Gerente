using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IEstadoService
    {
        Task<IEnumerable<EstadoViewModel>> Get();
        Task<EstadoViewModel> Get(int? id);
        void Add(EstadoViewModel obj, string nomeUsuario);
        void Edit(EstadoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}