using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class ContratoService : IContratoService
    {
        private readonly IContratoRepository _service;
        private readonly IMapper _mapper;

        public ContratoService(IContratoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ContratoViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<ContratoViewModel>>(lista);
        }

        public async Task<ContratoViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<ContratoViewModel>(obj);
        }

        public void Add(ContratoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Contrato>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(ContratoViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Contrato>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}