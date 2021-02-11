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
        public async Task<IEnumerable<EstadoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<EstadoViewModel>>(lista);
        }

        public async Task<EstadoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<EstadoViewModel>(obj);
        }

        public void Add(EstadoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Estado>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(EstadoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Estado>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}