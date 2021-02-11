using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IContratoService
    {
        Task<IEnumerable<ContratoViewModel>> Get();
        Task<ContratoViewModel> Get(int? id);
        void Add(ContratoViewModel obj, string nomeUsuario);
        void Edit(ContratoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}