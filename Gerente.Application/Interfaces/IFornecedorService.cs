using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IFornecedorService
    {
        Task<IEnumerable<FornecedorViewModel>> GetAsync();
        Task<FornecedorViewModel> GetAsync(int? id);
        Task<FornecedorViewModel> AddAsync(FornecedorViewModel obj);
        Task EditAsync(FornecedorViewModel obj);
        Task DeleteAsync(int id);
    }
}