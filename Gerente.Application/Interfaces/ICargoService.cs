using System.Collections.Generic;
using System.Threading.Tasks;
using Gerente.Application.ViewModels;

namespace Gerente.Application.Interfaces
{
    public interface ICargoService
    {
        Task<IEnumerable<CargoViewModel>> Get();
        Task<CargoViewModel> Get(int? id);
        void Add(CargoViewModel obj, string nomeUsuario);
        void Edit(CargoViewModel obj, string nomeUsuario);
        void Delete(int id, string nomeUsuario);
    }
}