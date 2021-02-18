using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Domain.Entities;

namespace Gerente.Domain.Interfaces
{
    public interface IContratoRepository
    {
        Task<IEnumerable<Contrato>> Get();
        Task<Contrato> Get(int? id);
        void Add(Contrato obj);
        void Edit(Contrato obj);
        void Delete(Contrato obj);
    }
}