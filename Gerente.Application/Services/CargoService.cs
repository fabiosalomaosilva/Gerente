using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class CargoService : ICargoService
    {
        private readonly ICargoRepository _service;
        private readonly IMapper _mapper;

        public CargoService(ICargoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CargoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<CargoViewModel>>(lista);
        }

        public async Task<CargoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<CargoViewModel>(obj);
        }

        public void Add(CargoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Cargo>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(CargoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Cargo>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}