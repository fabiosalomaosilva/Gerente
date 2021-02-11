using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ISecretariaService
    {
        Task<IEnumerable<SecretariaViewModel>> Get();
        Task<SecretariaViewModel> Get(int? id);
        void Add(SecretariaViewModel obj, string nomeUsuario);
        void Edit(SecretariaViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}