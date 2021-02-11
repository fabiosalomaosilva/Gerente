using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IAcompanhanteService
    {
        Task<IEnumerable<AcompanhanteViewModel>> Get();
        Task<AcompanhanteViewModel> Get(int? id);
        void Add(AcompanhanteViewModel obj, string nomeUsuario);
        void Edit(AcompanhanteViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}