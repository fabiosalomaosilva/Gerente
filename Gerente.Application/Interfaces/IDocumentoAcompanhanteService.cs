using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoAcompanhanteService
    {
        Task<IEnumerable<DocumentoAcompanhanteViewModel>> Get();
        Task<DocumentoAcompanhanteViewModel> Get(int? id);
        void Add(DocumentoAcompanhanteViewModel obj);
        void Edit(DocumentoAcompanhanteViewModel obj);
        void Delete(int id);
    }
}