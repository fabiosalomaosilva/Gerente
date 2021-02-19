using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoContratoService
    {
        Task<IEnumerable<DocumentoContratoViewModel>> GetAsync();
        Task<DocumentoContratoViewModel> GetAsync(int? id);
        Task<DocumentoContratoViewModel> AddAsync(DocumentoContratoViewModel obj);
        Task EditAsync(DocumentoContratoViewModel obj);
        Task DeleteAsync(int id);
    }
}