using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ISetorService
    {
        Task<IEnumerable<SetorViewModel>> Get();
        Task<SetorViewModel> Get(int? id);
        void Add(SetorViewModel obj, string nomeUsuario);
        void Edit(SetorViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}