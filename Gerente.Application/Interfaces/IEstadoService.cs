using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;

namespace Gerente.Application.Interfaces
{
    public interface IEstadoService
    {
        Task<ListData> GetAsync(PaginationDTO pagination, string name = null);
        Task<EstadoViewModel> GetAsync(int? id);
        Task<EstadoViewModel> AddAsync(EstadoViewModel obj);
        Task EditAsync(EstadoViewModel obj);
        Task DeleteAsync(int id);
    }
}