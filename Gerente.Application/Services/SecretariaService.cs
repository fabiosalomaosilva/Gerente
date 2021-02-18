using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class SecretariaService : ISecretariaService
    {
        private readonly ISecretariaRepository _service;
        private readonly IMapper _mapper;

        public SecretariaService(ISecretariaRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SecretariaViewModel>> Get()
        {
            var lista = await _service.Get();
            return _mapper.Map<IEnumerable<SecretariaViewModel>>(lista);
        }

        public async Task<SecretariaViewModel> Get(int? id)
        {
            var obj = await _service.Get(id);
            return _mapper.Map<SecretariaViewModel>(obj);
        }

        public void Add(SecretariaViewModel obj)
        {
            var objeto = _mapper.Map<Secretaria>(obj);
            _service.Add(objeto);
        }

        public void Edit(SecretariaViewModel obj)
        {
            var objeto = _mapper.Map<Secretaria>(obj);
            _service.Edit(objeto);
        }

        public void Delete(int id)
        {
            var obj = _service.Get(id).Result;
            _service.Delete(obj);
        }
    }
}