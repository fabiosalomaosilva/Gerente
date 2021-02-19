using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IServidorService
    {
        Task<IEnumerable<ServidorViewModel>> GetAsync();
        Task<ServidorViewModel> GetAsync(int? id);
        Task<ServidorViewModel> AddAsync(ServidorViewModel obj);
        Task EditAsync(ServidorViewModel obj);
        Task DeleteAsync(int id);
    }
}