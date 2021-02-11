using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class AcompanhanteService : IAcompanhanteService
    {
        private readonly IPessoaRepository _service;
        private readonly IMapper _mapper;

        public AcompanhanteService(IPessoaRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AcompanhanteViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<AcompanhanteViewModel>>(lista);
        }

        public async Task<AcompanhanteViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<AcompanhanteViewModel>(obj);
        }

        public void Add(AcompanhanteViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(AcompanhanteViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}