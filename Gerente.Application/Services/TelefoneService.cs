using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _service;
        private readonly IMapper _mapper;

        public TelefoneService(ITelefoneRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TelefoneViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<TelefoneViewModel>>(lista);
        }

        public async Task<TelefoneViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<TelefoneViewModel>(obj);
        }

        public async Task<TelefoneViewModel> AddAsync(TelefoneViewModel obj)
        {
            var objeto = _mapper.Map<Telefone>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<TelefoneViewModel>(objetoResult);
        }

        public async Task EditAsync(TelefoneViewModel obj)
        {
            var objeto = _mapper.Map<Telefone>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}