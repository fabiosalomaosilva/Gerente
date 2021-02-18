using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IMunicipioRepository
    {
        Task<IEnumerable<Municipio>> Get();
        Task<Municipio> Get(int? id);
        void Add(Municipio obj);
        void Edit(Municipio obj);
        void Delete(Municipio obj);
    }
}