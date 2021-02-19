using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoAcompanhanteService
    {
        Task<IEnumerable<DocumentoAcompanhanteViewModel>> GetAsync();
        Task<DocumentoAcompanhanteViewModel> GetAsync(int? id);
        Task<DocumentoAcompanhanteViewModel> AddAsync(DocumentoAcompanhanteViewModel obj);
        Task EditAsync(DocumentoAcompanhanteViewModel obj);
        Task DeleteAsync(int id);
    }
}