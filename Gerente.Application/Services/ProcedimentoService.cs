using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class ProcedimentoService : IProcedimentoService
    {
        private readonly IProcedimentoRepository _service;
        private readonly IMapper _mapper;

        public ProcedimentoService(IProcedimentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProcedimentoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<ProcedimentoViewModel>>(lista);
        }

        public async Task<ProcedimentoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<ProcedimentoViewModel>(obj);
        }

        public async Task<ProcedimentoViewModel> AddAsync(ProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<Procedimento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<ProcedimentoViewModel>(objetoResult);
        }

        public async Task EditAsync(ProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<Procedimento>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }

    }
}