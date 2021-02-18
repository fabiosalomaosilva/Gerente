using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoAditivoService
    {
        Task<IEnumerable<DocumentoAditivoViewModel>> Get();
        Task<DocumentoAditivoViewModel> Get(int? id);
        void Add(DocumentoAditivoViewModel obj);
        void Edit(DocumentoAditivoViewModel obj);
        void Delete(int id);
    }
}