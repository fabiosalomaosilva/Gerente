using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IFornecedorService
    {
        Task<IEnumerable<FornecedorViewModel>> Get();
        Task<FornecedorViewModel> Get(int? id);
        void Add(FornecedorViewModel obj, string nomeUsuario);
        void Edit(FornecedorViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}