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
        Task<IEnumerable<Aditivo>> Get();
        Task<Aditivo> Get(int? id);
        void Add(Aditivo obj, string nomeUsuario);
        void Edit(Aditivo obj, string nomeUsuario);
        void Delete(Aditivo obj, string nomeUsuario);
    }
}
