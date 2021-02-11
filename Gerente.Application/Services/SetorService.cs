using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class SetorService : ISetorService
    {
        private readonly ISetorRepository _service;
        private readonly IMapper _mapper;

        public SetorService(ISetorRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SetorViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<SetorViewModel>>(lista);
        }

        public async Task<SetorViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<SetorViewModel>(obj);
        }

        public void Add(SetorViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Setor>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(SetorViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Setor>(obj);
            _service.Edit(objeto, nomeUsuario);
        }

        public void Delete(int id, string nomeUsuario)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj, nomeUsuario);
        }
    }
}