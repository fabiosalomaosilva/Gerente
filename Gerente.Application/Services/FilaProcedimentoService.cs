using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Gerente.Application.Interfaces;
using Gerente.Application.ViewModels;
using Gerente.Domain.Entities;
using Gerente.Domain.Interfaces;

namespace Gerente.Application.Services
{
    public class FilaProcedimentoService : IFilaProcedimentoService
    {
        private readonly IFilaProcedimentoRepository _service;
        private readonly IMapper _mapper;

        public FilaProcedimentoService(IFilaProcedimentoRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FilaProcedimentoViewModel>> GetAsync()
        {
            var lista = await _service.GetAsync();
            return _mapper.Map<IEnumerable<FilaProcedimentoViewModel>>(lista);
        }

        public async Task<FilaProcedimentoViewModel> GetAsync(int? id)
        {
            var obj = await _service.GetAsync(id);
            return _mapper.Map<FilaProcedimentoViewModel>(obj);
        }

        public async Task<FilaProcedimentoViewModel> AddAsync(FilaProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<FilaProcedimento>(obj);
            var objetoResult = await _service.AddAsync(objeto);
            return _mapper.Map<FilaProcedimentoViewModel>(objetoResult);
        }

        public async Task EditAsync(FilaProcedimentoViewModel obj)
        {
            var objeto = _mapper.Map<FilaProcedimento>(obj);
            await _service.EditAsync(objeto);
        }

        public async Task DeleteAsync(int id)
        {
            var obj = await _service.GetAsync(id);
            await _service.DeleteAsync(obj);
        }
    }
}