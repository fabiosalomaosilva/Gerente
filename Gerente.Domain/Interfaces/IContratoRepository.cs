using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IContratoRepository
    {
        Task<IEnumerable<Contrato>> Get();
        Task<Contrato> Get(int? id);
        void Add(Contrato obj, string nomeUsuario);
        void Edit(Contrato obj, string nomeUsuario);
        void Delete(Contrato obj, string nomeUsuario);
    }
}