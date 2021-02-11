using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoAcompanhanteService
    {
        Task<IEnumerable<DocumentoAcompanhanteViewModel>> Get();
        Task<DocumentoAcompanhanteViewModel> Get(int? id);
        void Add(DocumentoAcompanhanteViewModel obj, string nomeUsuario);
        void Edit(DocumentoAcompanhanteViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}