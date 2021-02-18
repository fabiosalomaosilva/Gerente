using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoContratoService
    {
        Task<IEnumerable<DocumentoContratoViewModel>> Get();
        Task<DocumentoContratoViewModel> Get(int? id);
        void Add(DocumentoContratoViewModel obj);
        void Edit(DocumentoContratoViewModel obj);
        void Delete(int id);
    }
}