using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ITelefoneService
    {
        Task<IEnumerable<TelefoneViewModel>> Get();
        Task<TelefoneViewModel> Get(int? id);
        void Add(TelefoneViewModel obj, string nomeUsuario);
        void Edit(TelefoneViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}