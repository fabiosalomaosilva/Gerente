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
        public async Task<IEnumerable<SecretariaViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<SecretariaViewModel>>(lista);
        }

        public async Task<SecretariaViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<SecretariaViewModel>(obj);
        }

        public async Task<SecretariaViewModel> AddAsync(SecretariaViewModel obj)
        {
            var objeto = _mapper.Map<Secretaria>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<SecretariaViewModel>(objetoResult);
        }

        public async Task EditAsync(SecretariaViewModel obj)
        {
            var objeto = _mapper.Map<Secretaria>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}