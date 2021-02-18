using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IAditivoRepository
    {
        Task<IEnumerable<Aditivo>> GetAsync();
        Task<Aditivo> GetAsync(int? id);
        Task<Aditivo> AddAsync(Aditivo obj);
        Task EditAsync(Aditivo obj);
        Task DeleteAsync(Aditivo obj);
    }
}
