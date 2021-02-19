using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class LocalProcedimentoService : ILocalProcedimentoService
    {
        private readonly ILocalProcedimentoRepository _service;
        private readonly IMapper _mapper;

        public LocalProcedimentoService(ILocalProcedimentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LocalProcedimentoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<LocalProcedimentoViewModel>>(lista);
        }

        public async Task<LocalProcedimentoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<LocalProcedimentoViewModel>(obj);
        }

        public async Task<LocalProcedimentoViewModel> AddAsync(LocalProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<LocalProcedimento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<LocalProcedimentoViewModel>(objetoResult);
        }

        public async Task EditAsync(LocalProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<LocalProcedimento>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}