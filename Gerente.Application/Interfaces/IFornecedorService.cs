using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IFornecedorService
    {
        Task<IEnumerable<FornecedorViewModel>> Get();
        Task<FornecedorViewModel> Get(int? id);
        void Add(FornecedorViewModel obj);
        void Edit(FornecedorViewModel obj);
        void Delete(int id);
    }
}