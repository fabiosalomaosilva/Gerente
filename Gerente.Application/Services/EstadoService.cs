using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _service;
        private readonly IMapper _mapper;

        public EstadoService(IEstadoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EstadoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<EstadoViewModel>>(lista);
        }

        public async Task<EstadoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<EstadoViewModel>(obj);
        }

        public async Task<EstadoViewModel> AddAsync(EstadoViewModel obj)
        {
            var objeto = _mapper.Map<Estado>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<EstadoViewModel>(objetoResult);
        }

        public async Task EditAsync(EstadoViewModel obj)
        {
            var objeto = _mapper.Map<Estado>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}