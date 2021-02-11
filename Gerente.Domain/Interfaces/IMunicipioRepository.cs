using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IMunicipioRepository
    {
        Task<IEnumerable<Municipio>> Get();
        Task<Municipio> Get(int? id);
        void Add(Municipio obj, string nomeUsuario);
        void Edit(Municipio obj, string nomeUsuario);
        void Delete(Municipio obj, string nomeUsuario);
    }
}