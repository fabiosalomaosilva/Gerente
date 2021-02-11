using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IMunicipioService
    {
        Task<IEnumerable<MunicipioViewModel>> Get();
        Task<MunicipioViewModel> Get(int? id);
        void Add(MunicipioViewModel obj, string nomeUsuario);
        void Edit(MunicipioViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}