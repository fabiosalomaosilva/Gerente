using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface IDocumentoAditivoService
    {
        Task<IEnumerable<DocumentoAditivoViewModel>> GetAsync();
        Task<DocumentoAditivoViewModel> GetAsync(int? id);
        Task<DocumentoAditivoViewModel> AddAsync(DocumentoAditivoViewModel obj);
        Task EditAsync(DocumentoAditivoViewModel obj);
        Task DeleteAsync(int id);
    }
}