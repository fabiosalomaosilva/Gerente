using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IServidorService
    {
        Task<IEnumerable<ServidorViewModel>> Get();
        Task<ServidorViewModel> Get(int? id);
        void Add(ServidorViewModel obj, string nomeUsuario);
        void Edit(ServidorViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}