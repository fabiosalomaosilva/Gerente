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
        public async Task<IEnumerable<CargoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<CargoViewModel>>(lista);
        }

        public async Task<CargoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<CargoViewModel>(obj);
        }

        public async Task<CargoViewModel> AddAsync(CargoViewModel obj)
        {
            var objeto = _mapper.Map<Cargo>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<CargoViewModel>(objetoResult);
        }

        public async Task EditAsync(CargoViewModel obj)
        {
            var objeto = _mapper.Map<Cargo>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}