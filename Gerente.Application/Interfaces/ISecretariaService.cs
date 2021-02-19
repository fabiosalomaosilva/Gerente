using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ISecretariaService
    {
        Task<IEnumerable<SecretariaViewModel>> GetAsync();
        Task<SecretariaViewModel> GetAsync(int? id);
        Task<SecretariaViewModel> AddAsync(SecretariaViewModel obj);
        Task EditAsync(SecretariaViewModel obj);
        Task DeleteAsync(int id);
    }
}