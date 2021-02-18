using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<IEnumerable<Documento>> Get();
        Task<Documento> Get(int? id);
        void Add(Documento obj);
        void Edit(Documento obj);
        void Delete(Documento obj);
    }
}