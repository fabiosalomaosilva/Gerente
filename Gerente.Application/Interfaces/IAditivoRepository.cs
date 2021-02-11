using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAditivoService
    {
        Task<IEnumerable<AditivoViewModel>> Get();
        Task<AditivoViewModel> Get(int? id);
        void Add(AditivoViewModel obj, string nomeUsuario);
        void Edit(AditivoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}
