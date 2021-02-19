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
        public async Task<IEnumerable<AcompanhanteViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<AcompanhanteViewModel>>(lista);
        }

        public async Task<AcompanhanteViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<AcompanhanteViewModel>(obj);
        }

        public async Task<AcompanhanteViewModel> AddAsync(AcompanhanteViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<AcompanhanteViewModel>(objetoResult);
        }

        public async Task EditAsync(AcompanhanteViewModel obj)
        {
            var objeto = _mapper.Map<Pessoa>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}