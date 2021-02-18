using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IContratoService
    {
        Task<IEnumerable<ContratoViewModel>> Get();
        Task<ContratoViewModel> Get(int? id);
        void Add(ContratoViewModel obj);
        void Edit(ContratoViewModel obj);
        void Delete(int id);
    }
}