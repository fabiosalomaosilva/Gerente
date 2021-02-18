using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IEspecialidadeService
    {
        Task<IEnumerable<EspecialidadeViewModel>> Get();
        Task<EspecialidadeViewModel> Get(int? id);
        void Add(EspecialidadeViewModel obj);
        void Edit(EspecialidadeViewModel obj);
        void Delete(int id);
    }
}