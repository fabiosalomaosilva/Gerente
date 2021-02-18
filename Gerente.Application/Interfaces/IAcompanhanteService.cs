using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAcompanhanteService
    {
        Task<IEnumerable<AcompanhanteViewModel>> Get();
        Task<AcompanhanteViewModel> Get(int? id);
        void Add(AcompanhanteViewModel obj);
        void Edit(AcompanhanteViewModel obj);
        void Delete(int id);
    }
}