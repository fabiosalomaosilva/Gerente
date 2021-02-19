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
        public async Task<IEnumerable<ContratoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<ContratoViewModel>>(lista);
        }

        public async Task<ContratoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<ContratoViewModel>(obj);
        }

        public async Task<ContratoViewModel> AddAsync(ContratoViewModel obj)
        {
            var objeto = _mapper.Map<Contrato>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<ContratoViewModel>(objetoResult);
        }

        public async Task EditAsync(ContratoViewModel obj)
        {
            var objeto = _mapper.Map<Contrato>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}