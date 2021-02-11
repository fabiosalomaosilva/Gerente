using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IDocumentoRepository
    {
        Task<IEnumerable<Documento>> Get();
        Task<Documento> Get(int? id);
        void Add(Documento obj, string nomeUsuario);
        void Edit(Documento obj, string nomeUsuario);
        void Delete(Documento obj, string nomeUsuario);
    }
}