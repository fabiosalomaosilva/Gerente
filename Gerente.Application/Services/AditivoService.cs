using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class AditivoService : IAditivoService
    {
        private readonly IAditivoRepository _service;
        private readonly IMapper _mapper;

        public AditivoService(IAditivoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AditivoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<AditivoViewModel>>(lista);
        }

        public async Task<AditivoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<AditivoViewModel>(obj);
        }

        public void Add(AditivoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Aditivo>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(AditivoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Aditivo>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}