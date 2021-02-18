using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IMedicoService
    {
        Task<IEnumerable<MedicoViewModel>> Get();
        Task<MedicoViewModel> Get(int? id);
        void Add(MedicoViewModel obj);
        void Edit(MedicoViewModel obj);
        void Delete(int id);
    }
}