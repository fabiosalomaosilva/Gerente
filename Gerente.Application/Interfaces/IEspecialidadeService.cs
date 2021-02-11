using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IEspecialidadeService
    {
        Task<IEnumerable<EspecialidadeViewModel>> Get();
        Task<EspecialidadeViewModel> Get(int? id);
        void Add(EspecialidadeViewModel obj, string nomeUsuario);
        void Edit(EspecialidadeViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}