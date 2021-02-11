using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface ICargoRepository
    {
        Task<IEnumerable<Cargo>> Get();
        Task<Cargo> Get(int? id);
        void Add(Cargo obj, string nomeUsuario);
        void Edit(Cargo obj, string nomeUsuario);
        void Delete(Cargo obj, string nomeUsuario);
    }
}