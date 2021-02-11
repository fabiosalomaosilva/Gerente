using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class ServidorService : IServidorService
    {
        private readonly IPessoaRepository _service;
        private readonly IMapper _mapper;

        public ServidorService(IPessoaRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ServidorViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<ServidorViewModel>>(lista);
        }

        public async Task<ServidorViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<ServidorViewModel>(obj);
        }

        public void Add(ServidorViewModel obj, string nomeUsuario)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            _service.Add(objeto, nomeUsuario);
        }

        public void Edit(ServidorViewModel obj, string nomeUsuario)
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